using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_Технологии_программирования.Classes
{
    public class Problem
    {
        /// <summary>
        /// Номер проблемы
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Описание проблемы.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Конструктор класса Problem
        /// </summary>
        /// <param name="number">Номер проблемы</param>
        /// <param name="description">Описание проблемы</param>
        public Problem(int number, string description)
        {
            Number = number;
            Description = description;
        }
    }
}
