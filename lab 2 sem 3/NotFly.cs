﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_sem_3
{
    public class NotFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Не летает");
        }
      
    }
}