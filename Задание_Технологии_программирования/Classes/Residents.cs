using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_Технологии_программирования.Classes
{
    public class Resident
    {
        /// <summary>
        /// Имя жителя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Номер паспорта жителя
        /// </summary>
        public string PassportNumber { get; set; }

        /// <summary>
        /// Проблема жителя
        /// </summary>
        public Problem Problem { get; set; }

        /// <summary>
        /// Темперамент жителя
        /// </summary>
        public Temperament Temperament { get; set; }

        /// <summary>
        /// Конструктор класса Resident
        /// </summary>
        /// <param name="name">Имя жителя</param>
        /// <param name="passportNumber">Номер паспорта</param>
        /// <param name="problem">Проблема жителя</param>
        /// <param name="temperament">Темперамент жителя</param>
        public Resident(string name, string passportNumber, Problem problem, Temperament temperament)
        {
            Name = name;
            PassportNumber = passportNumber;
            Problem = problem;
            Temperament = temperament;
        }
    }
}
