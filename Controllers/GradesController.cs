using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eDziennikv2.Data;
using eDziennikv2.Models;
using eDziennikv2.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace eDziennikv2.Controllers
{
    public class GradesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public readonly Dictionary<int, string> gradesListItems = new Dictionary<int, string>
        {
            {1, "Niedostateczny" },
            {2, "Dopuszczający" },
            {3, "Dostateczny" },
            {4, "Dobry" },
            {5, "Bardzo dobry" },
            {6, "Celujący" }
        };

        public GradesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // GET: Grades
        public async Task<IActionResult> Index()
        {
            if(User.IsInRole("Administrator") || User.IsInRole("Nauczyciel"))
            {
                return _context.Grades != null ?
                            View(await _context.Grades
                    .Include(g => g.Subject)
                    .Include(g => g.IssuedBy)
                    .Include(g => g.IssuedTo)
                    .ToListAsync()) :
                            Problem("Entity set 'ApplicationDbContext.Grades'  is null.");
            }
            var loggedInUser = await _userManager.FindByNameAsync(User.Identity.Name);
            return _context.Grades != null ?
                        View(await _context.Grades
                .Include(g => g.Subject)
                .Include(g => g.IssuedBy)
                .Include(g => g.IssuedTo)
                .Where(g => g.IssuedTo.Equals(loggedInUser))
                .ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Grades'  is null.");
        }

        // GET: Grades/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Grades == null)
            {
                return NotFound();
            }

            var grades = await _context.Grades
                .Include(g => g.Subject)
                .Include(g => g.IssuedBy)
                .Include(g => g.IssuedTo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grades == null)
            {
                return NotFound();
            }

            return View(grades);
        }
        public async Task<IActionResult> Create()
        {
            var students = await _userManager.GetUsersInRoleAsync("Student");
            var model = new GroupUsersViewModel()
            {
                Users = students,
            };
            return View(model);
        }

        public async  Task<IActionResult> AddGrade(string id)
        {
            var subjectList = new List<SelectListItem>();
            foreach (Subjects subjectElement in _context.Subjects)
            {
                var selectItem = new SelectListItem()
                {
                    Text = subjectElement.Name,
                    Value = subjectElement.Id
                };
                subjectList.Add(selectItem);
            }
            var gradeList = new List<SelectListItem>();
            foreach (KeyValuePair<int, string> grade in this.gradesListItems)
            {
                var selectItem = new SelectListItem()
                {
                    Text = grade.Value,
                    Value = grade.Key.ToString()
                };
                gradeList.Add(selectItem);
            }
            var viewModel = new GradesViewModel()
            {
                StudentId = id,
                Subjects = subjectList,
                Grades = gradeList
            };
            return View(viewModel);
        }

        // POST: Grades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GradesViewModel model)
        {
                var newGrade = new Grades() 
                { 
                    Description = model.Description,
                    Grade = model.Grade,
                    Subject = _context.Subjects.Where(s => s.Id.Equals(model.SubjectId)).FirstOrDefault(),
                    IssuedBy = await _userManager.FindByNameAsync(User.Identity.Name),
                    IssuedTo = await _userManager.FindByIdAsync(model.StudentId)

                };
                _context.Add(newGrade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }

        // GET: Grades/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Grades == null)
            {
                return NotFound();
            }

            var grades = await _context.Grades.FindAsync(id);
            if (grades == null)
            {
                return NotFound();
            }
            return View(grades);
        }

        // POST: Grades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Description,Grade,CreationDate")] Grades grades)
        {
            if (id != grades.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradesExists(grades.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(grades);
        }

        // GET: Grades/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Grades == null)
            {
                return NotFound();
            }

            var grades = await _context.Grades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grades == null)
            {
                return NotFound();
            }

            return View(grades);
        }

        // POST: Grades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Grades == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Grades'  is null.");
            }
            var grades = await _context.Grades.FindAsync(id);
            if (grades != null)
            {
                _context.Grades.Remove(grades);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GradesExists(string id)
        {
          return (_context.Grades?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
