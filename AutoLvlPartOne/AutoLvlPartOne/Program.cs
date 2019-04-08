using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AutoLvlPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new DataSet("Books");
            dataSet.ExtendedProperties.Add("Owner", "ITstep");              //метаданные о наборе

            #region books columns
            DataTable booksTable = new DataTable("books");
            booksTable.Columns.Add(new DataColumn
            {
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementStep = 1,
                AutoIncrementSeed = 1,
                ColumnName = "Id",
                DataType = typeof(int),
                Unique = true,
            });
            booksTable.Columns.Add("name", typeof(string));
            booksTable.Columns.Add("authorId", typeof(int));
            booksTable.Columns.Add("price", typeof(int));
            #endregion

            #region books rows
            booksTable.Rows.Add("Fairytale", 1000, 1);

            DataRow row = booksTable.NewRow();
            row.BeginEdit();
            row.ItemArray = new object[] { "Fairytale p.2", 1200, 1 };
            row.SetAdded();
            row.EndEdit();

            booksTable.Rows.Add(booksTable.NewRow());
            #endregion

            dataSet.Tables.Add(booksTable);

            #region authors columns
            DataTable authorTable = new DataTable("authors");
            booksTable.Columns.Add(new DataColumn
            {
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementStep = 1,
                AutoIncrementSeed = 1,
                ColumnName = "Id",
                DataType = typeof(int),
                Unique = true,
            });
            booksTable.Columns.Add("name", typeof(string));

            #endregion

            #region authors rows

            authorTable.Rows.Add("Pushkin A.S");

            authorTable.Rows.Add(booksTable.NewRow());
            #endregion

            dataSet.Tables.Add(authorTable);

            DataRelation dataRelation = new DataRelation("author_books_fk", "authors", "books", new string[] { "id" }, new string[] { "authorId" }, false);

            dataSet.Relations.Add(dataRelation);
        }
    }
}
