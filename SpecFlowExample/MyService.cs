using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SpecFlowExample
{
    public class MyService
    {
        public void ReadCsvAndImportItem()
        {
            var reader = new StreamReader(File.OpenRead(@"c:\temp\TEST_items.csv"));
            List<string> searchList = new List<string>();
            int i = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (i != 0)
                {
                    var itemElements = line.Split(';');
                    FakeDatabase.ItemTable.Add(new Item
                    {
                        ItemNo = itemElements[0],
                        CreatedOn = itemElements[1],
                        ModifiedOn = itemElements[2],
                        Disabled = itemElements[3]
                    });
                }
                i++;
            }
        }

        public void Start()
        {
            ReadCsvAndImportItem();
        }
    }
}
