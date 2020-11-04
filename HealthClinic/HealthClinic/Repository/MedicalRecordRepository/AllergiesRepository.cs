/***********************************************************************
 * Module:  AllergiesRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.AllergiesRepository
 ***********************************************************************/

using Model.PatientDoctor;
using Repository.Csv;
using Repository.Csv.Converter;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.MedicalRecordRepository
{
    public class AllergiesRepository : CSVRepository<Allergies, int>, IAllergiesRepository
    {
        private const string ALLERGIES_FILE = "../../Resources/Data/allergies.csv";
        private static AllergiesRepository instance;

        public static AllergiesRepository Instance()
        {
            if (instance == null)
            {
                instance = new AllergiesRepository(
                new CSVStream<Allergies>(ALLERGIES_FILE, new AlergiesCSVConverter(",")),
                new IntSequencer());
            }
            return instance;
        }

        public AllergiesRepository(ICSVStream<Allergies> stream, ISequencer<int> sequencer)
            : base(stream, sequencer)
        {
        }

    }
}