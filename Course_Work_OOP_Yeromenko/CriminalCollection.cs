using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_OOP_Yeromenko
{
    class CriminalCollection
    {
        public List<Criminal> criminals = new List<Criminal>();
        private readonly string filePath = "criminals.json";

        public CriminalCollection() 
        {   
            LoadFromFile();
        } 
        public void Add()
        {
            var criminalForm = new CriminalForm();
            if (criminalForm.ShowDialog() == DialogResult.OK)
            {
                Criminal newCriminal = criminalForm.CriminalData;
                criminals.Add(newCriminal);
                SaveToFile();
            }
        }

        public void Remove(Criminal criminal)
        {
            criminals.Remove(criminal);
            SaveToFile();
        }

        public void Update(Criminal oldCriminal, Criminal updatedCriminal)
        {
            int index = criminals.IndexOf(oldCriminal);
            if (index >= 0)
            {
                criminals[index] = updatedCriminal;
            }
        }

        private void SaveToFile()
        {
            var options = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            File.WriteAllText(filePath, JsonConvert.SerializeObject(criminals, options));
        }

        private void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                var options = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                string json = File.ReadAllText(filePath);
                criminals = JsonConvert.DeserializeObject<List<Criminal>>(json, options) ?? new List<Criminal>();
            }
        }


        
    }
}
