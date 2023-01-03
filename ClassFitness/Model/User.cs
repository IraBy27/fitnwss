using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFitness.Model
{
    public class User
    {
        public string Name { get; }
        public Gender Gender { get; }
        public DateTime DateBirth { get; }
        public  double Height { get; set; }
        public double Width { get; set; }
        public User(string name, Gender gender, DateTime dateBirth, double height, double width)
        {
            #region Проверка региона

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name is not null",nameof(name));
            }
            if (gender == null) 
            {
                throw new ArgumentNullException("gender is not null",nameof(gender));
            }
            if (dateBirth <DateTime.Parse("01.01.1922")|| dateBirth >= DateTime.Now) {
                throw new ArgumentException("невозможная дата рождения", nameof(dateBirth));
            }
            if (height <= 50) {
                throw new ArgumentException("рост не может быть меньше равен 0", nameof(height));
            }
        
            if(width <= 0) {
                throw new ArgumentException("вес не может быть меньше равен 0", nameof(width));
            }
            #endregion
            Name = name;
            Gender = gender;
            DateBirth = dateBirth;
            Height = height;
            Width = width;
        }
    }
}
