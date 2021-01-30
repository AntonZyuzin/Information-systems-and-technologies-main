using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Implementation1
{
    public static class Matrix
    {
        public static int ScalarProduct(int[] vector1, int[] vector2) {
            int vectorLength = Math.Min(vector1.Length, vector2.Length);
            int scalar = 0;
            for (int i = 0; i < vectorLength; i++) {
                scalar = scalar + vector1[i] * vector2[i];
            }

            return scalar;
        }

        public static int[] GetFirstRowWithNegativeElement(DataGridView matrix) {
            int desiredRowIndex = 0;
            bool done = false;

            for (int i = 0; i < matrix.RowCount && !done; i++) {
                for (int j = 0; j < matrix.ColumnCount && !done; j++) {
                    if (int.Parse((string)matrix.Rows[i].Cells[j].Value) < 0) {
                        desiredRowIndex = i;
                        done = true;
                    }
                }
            }

            int[] row = ToArray(matrix.Rows[desiredRowIndex].Cells);

            return row;
        }

        public static int[] GetLastRowWithZeroElement(DataGridView matrix) {
            int desiredRowIndex = 0;

            // scan row by row, top to bottom
            for (int i = 0; i < matrix.RowCount; i++) {
                for (int j = 0; j < matrix.ColumnCount; j++) {
                    if (int.Parse((string)matrix.Rows[i].Cells[j].Value) == 0) {
                        desiredRowIndex = i;
                    }
                }
            }

            int[] row = ToArray(matrix.Rows[desiredRowIndex].Cells);

            return row;
        }

        private static int[] ToArray(DataGridViewCellCollection cells) {
            var toBeArray = new List<int>();

            for (int i = 0; i < cells.Count; i++) {
                toBeArray.Add(int.Parse((string)cells[i].Value));
            }

            return toBeArray.ToArray();
        }

        public static void CustomizeTable(DataGridView dataGridView, int n, int m)
        {
            dataGridView.RowCount = n;
            dataGridView.ColumnCount = m;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Height = 25;
            }
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 25;
            }
        }

        public static void FillTable(int[,] arr, DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
            }
        }
    }
}
