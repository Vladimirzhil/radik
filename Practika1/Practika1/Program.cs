using System;
using EfCoreTest1;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using Practika1;

namespace Practika1
{
    using 
        (ApplicationContext db = new ApplicationContext())
            {
                var typeofworks = db.Typeofworks.ToArray();
                Console.WriteLine(".");
                foreach (Typeofwork u in typeofworks)
                {
                    Console.WriteLine(u.Order_number + " " + u.Job_line_number + " " + u.Value + " "+ u.Job_ID);
                }
            } 
}
 /*{ using (ApplicationContext db = new ApplicationContext())
    {
        Typeofwork test = new Typeofwork { UserId = 3, Fio = "Сидоров", Age = 17 };
        db.Typeofwork.Add(test);
        db.SaveChanges();
        var typeofworks = db.Typeofworks.ToArray();
        Console.WriteLine("Список объектов");
        foreach (Typeofwork u in typeofworks)
        {
            Console.WriteLine(u.Order_number + " " + u.Job_line_number + " " + u.Value + " "+ u.Job_ID);
        }

    }

    using (ApplicationContext db = new ApplicationContext())
    {
        Typeofwork? upduser = (from typeofwork in db.Typeofworks where typeofwork.TypeofworkId == 3 select typeofwork).First();
        if (upduser != null)
        {
            upduser.Job_line = upduser.Job_line * 2;
            db.SaveChanges();
        }
        var typeofworks = db.Typeofworks.ToArray();
        Console.WriteLine("Список объектов");
        foreach (Typeofwork u in typeofworks)
        {
            Console.WriteLine(u.Order_number + " " + u.Job_line_number + " " + u.Value + " " + u.Job_ID);
        }

    }

    using (ApplicationContext db = new ApplicationContext())
    {
        Typeofwork? deluser = (from Typeofwork in db.Typeofworks where typeofwork.TypeofworkId == 3 select typeofwork).First();
        if (deluser != null)
        {
            db.Typeofworks.Remove(deluser);
            db.SaveChanges();
        }
        var typeofworks = db.Typeofworks.ToArray();
        Console.WriteLine("Список объектов");
        foreach (Typeofwork u in typeofworks)
        {
            Console.WriteLine(u.Order_number + " " + u.Job_line_number + " " + u.Value + " " + u.Job_ID);
        }

    } 
}*/

