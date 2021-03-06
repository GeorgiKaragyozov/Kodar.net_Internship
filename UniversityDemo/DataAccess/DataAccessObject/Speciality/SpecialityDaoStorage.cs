﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Speciality
{
    public class SpecialityDaoStorage
    {
        public static List<Model.Speciality> Specialities = new List<Model.Speciality>();

        public static IDictionary<long, Model.Speciality> Dictionary =
            new Dictionary<long, Model.Speciality>();

        static SpecialityDaoStorage()
        {
            Model.Speciality speciality1 = new Model.Speciality()
            {

            };

            Model.Speciality speciality2 = new Model.Speciality()
            {

            };

            Model.Speciality speciality3 = new Model.Speciality()
            {

            };

            Specialities.Add(speciality1);
            Specialities.Add(speciality2);
            Specialities.Add(speciality3);

            Dictionary.Add(speciality1.Id, speciality1);
            Dictionary.Add(speciality2.Id, speciality2);
            Dictionary.Add(speciality3.Id, speciality3);
        }
    }
}
