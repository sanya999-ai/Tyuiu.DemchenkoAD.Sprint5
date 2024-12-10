﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.DemchenkoAD.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V14.txt");

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] >= 'a' && line[i] <= 'z') && (char.IsLower(line[i])))
                        {
                            strLine += char.ToUpper(line[i]);
                        }
                        else
                        {
                            strLine += line[i];
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }

            return pathSaveFile;

        }
    }
}
