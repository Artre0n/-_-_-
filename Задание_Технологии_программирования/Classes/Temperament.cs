using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_Технологии_программирования.Classes
{
    public class Temperament
    {
        /// <summary>
        /// Уровень скандальности (от 0 до 10)
        /// </summary>
        public int ScandalLevel { get; set; }

        /// <summary>
        /// Уровень интеллекта (0 - тупой, 1 - умный)
        /// </summary>
        public int Intelligence { get; set; }

        /// <summary>
        /// Конструктор класса Temperament
        /// </summary>
        /// <param name="scandalLevel">Уровень скандальности</param>
        /// <param name="intelligence">Уровень интеллекта</param>
        public Temperament(int scandalLevel, int intelligence)
        {
            ScandalLevel = scandalLevel;
            Intelligence = intelligence;
        }
    }
}
