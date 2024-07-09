using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aggregates
{
    public class MyIo
    {
        public string[] CondenseList(string[] input, int count)
        {
            string[] outputList = null;

            if (count > 0)
            {
                outputList = new string[count];

                for (int index = 0; index < count; index++)
                {
                    outputList[index] = input[index];
                }
            }

            return outputList;
        }

        public List<string> ReadFile(string fileName)
        {
            List<string> lines = new List<string>();

            System.IO.StreamReader reader = new System.IO.StreamReader(fileName);

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            reader.Close();

            return lines;
        }

        public string[] ReadFileArray(string fileName)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(fileName);

            int resize = 50;

            string[] readArray = new string[resize];

            string line;

            int counter = 0;

            while ((line = reader.ReadLine()) != null)
            {
                readArray = ResizeArray(readArray, counter, resize);

                readArray.SetValue(line, counter);

                counter++;
            }

            reader.Close();

            string[] finalArray = new string[counter];

            for (int index = 0; index < counter; index++)
            {
                string checkline = readArray[index];
                string newLine = "";


                for (int checkNull = 0; checkNull < checkline.Length; checkNull++)
                {
                    if (checkline[checkNull] != 0)
                    {
                        newLine += checkline[checkNull];
                    }
                }

                finalArray[index] = newLine;
            }

            return finalArray;

        }

        public string[] ResizeArray(string[] array, int counter, int resize)
        {
            string[] returnArray = null;

            if (counter == 0)
            {
                return array;
            }

            if (counter % resize != 0)
            {
                return array;
            }

            // need to resize

            returnArray = new string[array.Length + resize];

            for (int index = 0; index < array.Length; index++)
            {
                returnArray[index] = array[index];
            }

            return returnArray;
        }

        public bool WriteFile(string fileName, ArrayList output)
        {
            return WriteFile(fileName, (string[])output.ToArray(typeof(string)));
        }
        public bool WriteFile(string fileName, List<string> output)
        {
            return WriteFile(fileName, output.ToArray());
        }

        public bool WriteFile(string fileName, string[] lines)
        {
            bool success = false;

            try
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName);

                for (int index = 0; index < lines.Length; index++)
                {
                    writer.WriteLine(lines[index]);
                }

                writer.Close();

                success = true;
            }
            catch
            {
            }

            return success;
        }
    }
}
