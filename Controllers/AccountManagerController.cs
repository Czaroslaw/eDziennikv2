using eDziennikv2.Data;
using eDziennikv2.Models;
using eDziennikv2.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace eDziennikv2.Controllers
{
    public class AccountManagerController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public AccountManagerController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }

        // GET: Users/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _userManager.Users == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var userGroupRecord = _context.UserGroups.Where(g => g.UserId.Equals(id)).FirstOrDefault();
            var groupId = "";
            if (userGroupRecord != null)
            {
               groupId = userGroupRecord.GroupId;
            }
            var availableGroups = new List<SelectListItem>();
            foreach(Groups group in _context.Groups)
            {
                var selectItem = new SelectListItem()
                {
                    Text = group.Name,
                    Value = group.Id
                };
                availableGroups.Add(selectItem);
            }
            var groupRecord = _context.Groups.Where(g => g.Id.Equals(groupId)).FirstOrDefault();
            var viewModel = new AccountManagerViewModel()
            {
                User = user,
                Group = groupRecord,
                AvailableGroupList = availableGroups,
        };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AccountManagerViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.User.Id);
            if (user == null)
            {
                return View();
            }
            user.FirstName = model.User.FirstName;
            user.LastName = model.User.LastName;
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", $"Nie można zaktualizować użytkownika: {result.Errors.First().Description}");
                return View(model);
            }
            try
            {
                if (model.Group.Id == "empty")
                {
                    var record = _context.UserGroups.Where(g => g.UserId == model.User.Id).FirstOrDefault();
                    _context.Remove(record);
                    _context.SaveChanges();
                }

                else
                {
                    var record = _context.UserGroups.Where(g => g.UserId == model.User.Id).FirstOrDefault();
                    if(record == null)
                    {
                        UserGroups newRecord = new UserGroups() {
                            Id = Guid.NewGuid().ToString(),
                            GroupId = model.Group.Id,
                            UserId = model.User.Id,
                        };
                        _context.UserGroups.Add(newRecord);
                    }
                    else
                    {
                        record.GroupId = model.Group.Id;
                    }
                    _context.SaveChanges();
                }
            }
            catch (Exception) {

                ModelState.AddModelError("", $"Nie można zmienić klasy użytkownikowi: {result.Errors.First().Description}");
                return View(model);
            }
            return RedirectToAction("Index");

        }
    }
}
