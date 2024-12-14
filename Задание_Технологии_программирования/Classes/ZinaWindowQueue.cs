using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_Технологии_программирования.Classes
{
    public class Zina
    {
        private Stack<Resident> clients = new Stack<Resident>();

        /// <summary>
        /// Добавляет жителя в стек
        /// </summary>
        /// <param name="resident">Житель для добавления</param>
        public void AddToStack(Resident resident)
        {
            clients.Push(resident);
        }

        /// <summary>
        /// Обрабатывает жителей в стеке
        /// </summary>
        public void DirectionForResidents()
        {
            while (clients.Count > 0)
            {
                Resident resident = clients.Pop();
                HandleScandalist(resident);
                int window = DetermineWindow(resident);

                Console.WriteLine($"Житель {resident.Name} (Паспорт: {resident.PassportNumber}) " +
                                  $"идет в окно {window} по проблеме: {resident.Problem.Description}");
            }
        }

        /// <summary>
        /// Определяет, в какое окно должен идти житель
        /// </summary>
        /// <param name="resident">Житель, для которого определяется окно</param>
        /// <returns>Номер окна</returns>
        private int DetermineWindow(Resident resident)
        {
            if (resident.Temperament.Intelligence == 0)
            {
                Random randomizer = new Random();
                return randomizer.Next(1, 4);
            }


            switch (resident.Problem.Number)
            {
                case 1:
                    return 1; // Проблемы с отоплением
                case 2:
                    return 2; // Проблемы с оплатой
                default:
                    return 3; // Остальные проблемы
            }
        }

        /// <summary>
        /// Обрабатывает скандалиста, позволяя ему обгонять других в очереди.
        /// </summary>
        /// <param name="resident">Скандалист для обработки.</param>
        public void HandleScandalist(Resident resident)
        {
            if (resident.Temperament.ScandalLevel >= 5)
            {
                int skipCount = new Random().Next(0, clients.Count + 1); 

                List<Resident> skippedResidents = new List<Resident>();
                for (int i = 0; i < skipCount; i++)
                {
                    if (clients.Count > 0)
                    {
                        skippedResidents.Add(clients.Pop());
                    }
                }

                Console.WriteLine($"Житель {resident.Name} (Паспорт: {resident.PassportNumber}) скандалист! Он обгоняет {skipCount} человек.");
            }
            else
            {
                Console.WriteLine($"Житель {resident.Name} (Паспорт: {resident.PassportNumber}) не скандалист.");
            }
        }


        /// <summary>
        /// Ввод данных о жителях.
        /// </summary>
        public void InputResidents()
        {
            var residentsInput = new List<(string Name, string PassportNumber, int ProblemNumber, int ScandalLevel, int Intelligence)>
            {
                ("Андрей", "1122334455", 3, 5, 1),
                ("Николай", "2233445566", 1, 2, 0),
                ("Анна", "3344556677", 2, 4, 1)
            };

            foreach (var data in residentsInput)
            {
                var problem = new Problem(data.ProblemNumber, data.ProblemNumber switch
                {
                    1 => "Проблема с отоплением",
                    2 => "Проблема с оплатой",
                    _ => "Другая проблема",
                });

                var temperament = new Temperament(data.ScandalLevel, data.Intelligence);
                var resident = new Resident(data.Name, data.PassportNumber, problem, temperament);
                AddToStack(resident);
            }
        }
    }
}
