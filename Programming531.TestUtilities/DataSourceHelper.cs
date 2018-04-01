using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming531.TestUtilities
{
    /// <summary>
    /// <para>This gets the value of a row in a data driven test.</para>
    /// </summary>
    public class DataSourceHelper
    {
        /// <summary>
        /// <para>This is the test class whose data context will give the data row.</para>
        /// </summary>
        public IDataDrivenTest DataDrivenTest { get; private set; }

        public DataSourceHelper(IDataDrivenTest dataDrivenTest)
        {
            this.DataDrivenTest = dataDrivenTest;
        }

        /// <summary>
        /// <para>This gets a double from the current data row for a data driven test.</para>
        /// </summary>
        /// <param name="nameOfField">
        /// <para>The name of the field in the data row</para>
        /// </param>
        /// <returns></returns>
        public double GetDouble(string nameOfField)
        {
            string fieldValue = GetString(nameOfField);
            return Convert.ToDouble(fieldValue);
        }

        /// <summary>
        /// <para>This gets a integer from the current data row for a data driven test.</para>
        /// </summary>
        /// <param name="nameOfField">
        /// <para>The name of the field in the data row</para>
        /// </param>
        /// <returns></returns>
        public int GetInt(string nameOfField)
        {
            string fieldValue = GetString(nameOfField);
            return Convert.ToInt32(fieldValue);
        }

        /// <summary>
        /// <para>This gets a string from the current data row for a data driven test.</para>
        /// </summary>
        /// <param name="nameOfField">
        /// <para>The name of the field in the data row</para>
        /// </param>
        /// <returns></returns>
        public string GetString(string nameOfField)
        {
            return (string)this.DataDrivenTest.TestContext.DataRow[nameOfField];
        }
    }
}
