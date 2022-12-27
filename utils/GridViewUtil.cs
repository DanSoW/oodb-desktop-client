using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodb_desktop_client.utils
{
    public class GridViewUtil
    {
        /// <summary>
        /// Линейный поиск элемента в GridView
        /// </summary>
        /// <param name="data">Данные типа DataGridView</param>
        /// <param name="column">Название столбца</param>
        /// <returns>Индекс найденного элемента</returns>
        static public int GetIndexColumnByKey(DataGridView data, string column)
        {
            var index = -1;

            for(var i = 0; i < data.Columns.Count; i++)
            {
                if (data.Columns[i].Name == column)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Линейный поиск элемента в GridView
        /// </summary>
        /// <typeparam name="V"> Тип данных значения</typeparam>
        /// <param name="data">Данные типа DataGridView</param>
        /// <param name="key">Ключ</param>
        /// <param name="value">Значение</param>
        /// <returns>Индекс найденного элемента</returns>
        static public int GetIndexByValue<T>(DataGridView data, string column, T value) where T : IComparable<T>
        {
            var indexColumn = GetIndexColumnByKey(data, column);
            if(indexColumn < 0)
            {
                return -1;
            }

            int index = -1;

            for(var i = 0; i < data.Rows.Count; i++)
            {
                if ((data.Rows[i].Cells[indexColumn].Value != null) && 
                    ((IComparable<T>)data.Rows[i].Cells[indexColumn].Value).CompareTo(value) == 0)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
