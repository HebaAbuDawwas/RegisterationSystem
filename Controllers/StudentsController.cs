using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace FinalProject.Controllers
{
    [Authorize]

    public class StudentsController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public StudentsController(DataContext context,IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        //Get
        public IActionResult FindStudent()
        {
            FindStudent findStudent= new FindStudent();
            findStudent.Students = _context.tblStudent.ToList();
            return View(findStudent);
        }
        //Post
        [HttpPost]
        public IActionResult FindStudent(FindStudent model)
        {
            List<Student> SearchedFor = new List<Student>();
            model.Students = _context.tblStudent.ToList();
            if (model.studentName is not null)
                SearchedFor.AddRange(model.Students.Where(p => p.studentName.ToLower().Contains(model.studentName.ToLower())));
            model.Students = SearchedFor;
            return View(model);
        }
        public IActionResult ShowStudentSummary()
        {
            StudentSummary model = new StudentSummary();

            model.Students = _context.tblStudent.Include(p => p.StudentCourses).ThenInclude(a => a.Course);

            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> ShowStudentSummary(StudentSummary model)
        {
            if (model.studentName is null)
            {
                model.Students = await _context.tblStudent.Include(p => p.StudentCourses).ThenInclude(a => a.Course).ToListAsync();
                return View(model);

            }
            model.Students = await _context.tblStudent.Where(p => p.studentName.ToLower().Contains(model.studentName.ToLower())).Include(p => p.StudentCourses
                ).ThenInclude(a => a.Course).ToListAsync();
            return View( model);
        }

        // GET: Students
        public async Task<IActionResult> Index(string Sortby)
        {
            if (Sortby is null) Sortby = "";
            switch (Sortby.ToLower())
            {
                case "dsc":
                    return View(await _context.tblStudent.OrderByDescending(s => s.studentName).ToListAsync());
                    break;
                case "asc":
                    return View(await _context.tblStudent.OrderBy(s => s.studentName).ToListAsync());
                    break;
                default:
                    return View(await _context.tblStudent.ToListAsync());
                    break;

            }
           
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.tblStudent
                .FirstOrDefaultAsync(m => m.studentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("studentId,studentName,email,phone,imagePath,imageFile")] Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.imageFile != null)
                {
                    string wwwrootPath = _webHostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + "_" + student.imageFile.FileName;
                    string path = Path.Combine(wwwrootPath + "/Images/" + fileName);

                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await student.imageFile.CopyToAsync(filestream);
                    }
                    student.imagePath = fileName;
                }

                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.tblStudent.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("studentId,studentName,email,phone,imagePath,imageFile")] Student student)
        {
            if (id != student.studentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (student.imageFile != null)
                {
                    string wwwrootPath = _webHostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + "_" + student.imageFile.FileName;
                    string path = Path.Combine(wwwrootPath + "/Images/" + fileName);

                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await student.imageFile.CopyToAsync(filestream);
                    }
                    student.imagePath = fileName;
                }
                _context.Update(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.tblStudent
                .FirstOrDefaultAsync(m => m.studentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.tblStudent.FindAsync(id);
            _context.tblStudent.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.tblStudent.Any(e => e.studentId == id);
        }
    }
}
