using FireSharp.Response;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyzOo.Methods
{
    internal class CellCrud
    {
        Firebase conn = new Firebase();

        public void SetData(int id, int number, bool cleaning, string description)
        {
            try
            {
                Cell set = new Cell()
                {
                    Id = id,
                    Number = number,
                    Cleaning = cleaning,
                    Description = description
                };
                var SetData = conn.client.Set("cells/" + id, set);

                MessageBox.Show($"Cela {number} Registada com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        public void UpdateData(int id, int number, bool cleaning, string description)
        {
            try
            {
                Cell set = new Cell()
                {
                    Id = id,
                    Number = number,
                    Cleaning = cleaning,
                    Description = description
                };
                var SetData = conn.client.Update("cells/" + id, set);

                MessageBox.Show($"Cela {number} Atualizada com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        public void DeleteData(int id)
        {
            try
            {
                var SetData = conn.client.Delete("cells/" + id);

                MessageBox.Show($"Cela {id} Apagada com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        public List<Cell> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("cells");
                Dictionary<string, Cell> listData = JsonConvert.DeserializeObject<Dictionary<string, Cell>>(al.Body.ToString());
                List<Cell> allData = new List<Cell>();

                // verify
                foreach (var kvp in listData)
                {
                    allData.Add(kvp.Value);
                }

                return allData;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                return null;
            }
        }

        public Cell GetCell(int id)
        {
            try
            {
                var GetData = conn.client.Get("cells/" + id);

                if (GetData.Body == "null")
                {
                    Console.WriteLine($"No data found for Cell with ID {id}");
                    return null;
                }

                Cell cell = JsonConvert.DeserializeObject<Cell>(GetData.Body.ToString());
                return cell;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                return null;
            }
        }
    }
}
