using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace GeneratorDocs
{
    public class Editting
    {
       

        string UFamile;
        string UIO;
        string Ulear;
        string Uspec1;
        string Uspec2;
        string UlearnPr;
        string Uqual;

        string Famile;
        string IO;
        string lear;
        string spec1;
        string spec2;
        string learnPr;
        string qual;

        string filename;

        public Editting(string filen, string U1, string U2, string U3, string U4, string U5, string U6, string U7, string E1, string E2, string E3, string E4, string E5, string E6, string E7)
        {
            UFamile = U1;
            UIO = U2;
            Ulear = U3;
            Uspec1 = U4;
            Uspec2 = U5;
            UlearnPr = U6;
            Uqual = U7;

            Famile = E1;
            IO = E2;
            lear = E3;
            spec1 = E4;
            spec2 = E5;
            learnPr = E6;
            qual = E7;

            filename = filen;
        }

        /// <summary>
        /// Функция для замены
        /// </summary>
        /// <param name="was">То, что было</param>
        /// <param name="will">Что должно быть</param>
        private void Replace(Word.Find find, string was, string will)
        {
            find.ClearFormatting();
            find.Replacement.ClearFormatting();
            find.Text = was;
            find.Replacement.Text = will;
            object missing = Type.Missing;
            object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
            find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref replaceAll, ref missing, ref missing, ref missing, ref missing);
        }

        private int infoCount()
        {
            int chys;
            StreamReader read = new StreamReader("info.count");
            chys = Convert.ToInt32(read.ReadLine());
            read.Close();
            chys++;
            StreamWriter write = new StreamWriter("info.count", false);
            write.WriteLine(chys);
            write.Close();
            return chys; 
        }

        public void mau()
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = false;
            Object filenam = filename;
            Object confirmConversions = Type.Missing;
            Object readOnly = Type.Missing;
            Object addToRecentFiles = Type.Missing;
            Object passwordDocument = Type.Missing;
            Object passwordTemplate = Type.Missing;
            Object revert = Type.Missing;
            Object writePasswordDocument = Type.Missing;
            Object writePasswordTemplate = Type.Missing;
            Object format = Type.Missing;
            Object encoding = Type.Missing;
            Object visible = Type.Missing;
            Object openConflictDocument = Type.Missing;
            Object openAndRepair = Type.Missing;
            Object documentDirection = Type.Missing;
            Object noEncodingDialog = Type.Missing;
            app.Documents.Open(ref filenam, ref confirmConversions, ref readOnly, ref addToRecentFiles,
                ref passwordDocument, ref passwordTemplate, ref revert, ref writePasswordDocument, ref writePasswordTemplate,
                ref format, ref encoding, ref visible, ref openConflictDocument, ref openAndRepair, ref documentDirection, ref noEncodingDialog);

            Microsoft.Office.Interop.Word.Find find = app.Selection.Find;

            Replace(find, "РегН", "ХА");
            Replace(find, "RegN", "KH");
            Replace(find, "Хвамилие", UFamile);
            Replace(find, "Имярек", UIO);
            Replace(find, "УчебнЗав", Ulear);
            Replace(find, "спецсть", Uspec1);
            Replace(find, "спеця", Uspec2);
            Replace(find, "обучпрг", UlearnPr);
            Replace(find, "профквал", Uqual);
            Replace(find, "LastName", Famile);
            Replace(find, "FirstName", IO);
            Replace(find, "NameCollege", lear);
            Replace(find, "SubArea", spec1);
            Replace(find, "StPrg", spec2);
            Replace(find, "EdPrg", learnPr);
            Replace(find, "PrQual", qual);
            int T = infoCount();
            Replace(find, "000000", Convert.ToString(T));
            
            object saveOptionsObject = Word.WdSaveOptions.wdSaveChanges;
            app.Quit(saveOptionsObject, Type.Missing, Type.Missing);

        }
    }
}
