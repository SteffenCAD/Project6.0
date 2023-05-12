using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;

public class ARconfig
{
    public void save(string file)
    {
        XmlSerializer ser = new XmlSerializer(this.GetType());
        StreamWriter sw = new StreamWriter(file);

        ser.Serialize(sw, this);
        sw.Close();
    }       

    public object load(string file, Type type)
    {
        Type thistype = this.GetType();

        XmlSerializer ser = new XmlSerializer(type);
        Stream sr = new FileStream(file, FileMode.Open);    

        object values = ser.Deserialize(sr);
        sr.Close();

        return values;
    }

    public object load(string file, Type type, bool create = false)
    {
        if(create)
        {
            if(!File.Exists(file))
            {
                object typeobj = Activator.CreateInstance(type);

                XmlSerializer seri = new XmlSerializer(type);
                StreamWriter sw = new StreamWriter(file);

                seri.Serialize(sw, typeobj);
                sw.Close();
            }
        }

        Type thistype = this.GetType();

        XmlSerializer ser = new XmlSerializer(type);
        Stream sr = new FileStream(file, FileMode.Open);

        object values = ser.Deserialize(sr);
        sr.Close();

        return values;
    }

    //automatic handling of filepath   
    public object load(Type type)
    {
        string file = Application.dataPath + "//ARcomConfig.xml";

        if (!File.Exists(file))
        {
            object typeobj = Activator.CreateInstance(type);

            XmlSerializer seri = new XmlSerializer(type);
            StreamWriter sw = new StreamWriter(file);

            seri.Serialize(sw, typeobj);
            sw.Close();
        }
            
        Type thistype = this.GetType();

        XmlSerializer ser = new XmlSerializer(type);
        Stream sr = new FileStream(file, FileMode.Open);

        object values = ser.Deserialize(sr);
        sr.Close();

        return values;
    }
    public void save(object settings)
    {
        string file = Application.dataPath + "//ARcomConfig.xml";

        XmlSerializer ser = new XmlSerializer(settings.GetType());
        StreamWriter sw = new StreamWriter(file);

        ser.Serialize(sw, this);
        sw.Close();
    }
}
