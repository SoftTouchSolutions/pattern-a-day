
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;

namespace tictactoeweb.Shared.DesignPatterns
{
    public class PrintableObject
    {
        public override string ToString()
        {
            return this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.SetProperty | BindingFlags.Public)
            .Aggregate(this.GetType().FullName+Environment.NewLine, (acc, v) => 
                acc + $"{v.Name} =" 
                    + $"{(IsPrintable(v.GetValue(this))?v.GetValue(this):(v.GetValue(this) is PrintableObject?v.GetValue(this).ToString():String.Empty))}" 
                    + $"{Environment.NewLine}");
        }
        public static bool IsPrintable(object value)
        {
            return value is sbyte
                    || value is byte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is long
                    || value is ulong
                    || value is float
                    || value is double
                    || value is decimal
                    || value is string
                    ;
        }
    }
}