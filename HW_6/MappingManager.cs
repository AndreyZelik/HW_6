using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HW_6
{
    class MappingManager<what,where>
        where what : class
        where where : class, new()
    {
        public where mapObject(what obj )
        {
            where resultObj = new where();

            System.Attribute[] attr = System.Attribute.GetCustomAttributes(typeof(where));

            foreach (var a in attr)
            {
                if (a is HW_6.MapAttribute)
                {
                    foreach (var p in typeof(where).GetProperties())
                    {
                        foreach (var prop_attr in p.GetCustomAttributes(true))
                        {
                            if (prop_attr is HW_6.MapAttribute)
                            {
                                resultObj.GetType().GetRuntimeProperty(p.Name).SetValue(
                                        resultObj, obj.GetType().GetRuntimeProperty(((HW_6.MapAttribute)prop_attr).mappingFiledName).GetValue(obj)
                                    );
                            }
                        }
                    }
                }
            }
            return resultObj;
        }

    }
}
