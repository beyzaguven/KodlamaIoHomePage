using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHomePage
{
    class KodlamaIoDal
    {
        private List<Course> courses;
        private List<Category> categories;
        private List<Instructor> instructors;

        public KodlamaIoDal()
        {
            courses = new List<Course>();
            categories = new List<Category>();
            instructors = new List<Instructor>();
        }

        //CRUD operasyonları

        //create operasyonları
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public void AddInstructor(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        //read operasyonları
        public List<Course> GetAllCourses()
        {
            return courses;
        }

        public List<Category> GetAllCategories()
        {
            return categories;
        }

        public List<Instructor> GetAllInstructors()
        {
            return instructors;
        }

        public Course GetCourseById(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }

        public Category GetCategoryById(int id)
        {
            return categories.FirstOrDefault(c => c.Id == id);
        }

        public Instructor GetInstructorById(int id)
        {
            return instructors.FirstOrDefault(i => i.Id == id);
        }

        //update operasyonları
        public void UpdateCourse(Course updatedCourse)
        {
            var course = courses.FirstOrDefault(c => c.Id == updatedCourse.Id);
            if (course != null)
            {
                course.Title = updatedCourse.Title;
                course.Category = updatedCourse.Category;
                course.Instructor = updatedCourse.Instructor;
            }
        }

        public void UpdateCategory(Category updatedCategory)
        {
            var category = categories.FirstOrDefault(c => c.Id == updatedCategory.Id);
            if (category != null)
            {
                category.Name = updatedCategory.Name;
            }
        }

        public void UpdateInstructor(Instructor updatedInstructor)
        {
            var instructor = instructors.FirstOrDefault(i => i.Id == updatedInstructor.Id);
            if (instructor != null)
            {
                instructor.Name = updatedInstructor.Name;
            }
        }

        //delete operasyonları
        public void DeleteCourse(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);
            if (course != null)
            {
                courses.Remove(course);
            }
        }

        public void DeleteCategory(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                categories.Remove(category);
            }
        }

        public void DeleteInstructor(int id)
        {
            var instructor = instructors.FirstOrDefault(i => i.Id == id);
            if (instructor != null)
            {
                instructors.Remove(instructor);
            }
        }
    }
}
