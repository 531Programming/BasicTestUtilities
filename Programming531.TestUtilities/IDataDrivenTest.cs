using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming531.TestUtilities
{
    /// <summary>
    /// <para>This is a test class that has a test context for a data driven test.</para>
    /// <para>This is used by the data driven test helper.</para>
    /// </summary>
    public interface IDataDrivenTest
    {
        TestContext TestContext { get; set; }
    }
}
