using NUnit.Framework;
using System;
using System.Collections.Generic;
using Traveller.DomainServices;
using Traveller.RouteService;
using Traveller.RouteService.DataContainer;
using Traveller.RouteService.Evaluator;
using Traveller.RouteService.Helpers;
using Traveller.RouteService.Rules;
using Traveller.RuleService;

namespace Test.RouteServiceUnitTest
{
    public class RouteServiceTest
    {
        private BorderCrossingService frontierService;

        public RouteServiceTest() {   }

    
        [SetUp]
        public void Setup()
        {
         

        }

        [Test]
        public void Test1()
        {
            BlockConnection blockConnection = new BlockConnection('V', 'C', false);

            bool result = blockConnection.Validate(new List<char> { 'V', 'C', 'X', 'X', 'X', 'X' });

            Assert.AreEqual(false, result);
        }
        [Test]
        public void Test2()
        {
            BlockConnection blockConnection = new BlockConnection('V', 'C', false);

            bool result = blockConnection.Validate(new List<char> { 'V', 'X', 'C', 'X', 'X', 'X', 'X' });

            Assert.AreEqual(true, result);
        }
        [Test]
        public void Test3()
        {
            CountryBMustFollowCountryA mustBeConsecutive = new CountryBMustFollowCountryA('V', 'C', false);

            bool result = mustBeConsecutive.Validate(new List<char> { 'V', 'X', 'C', 'X', 'X', 'X', 'X' });

            Assert.AreEqual(false, result);
        }
        [Test]
        public void Test4()
        {
            CountryBMustFollowCountryA mustBeConsecutive = new CountryBMustFollowCountryA('V', 'C', false);

            bool result = mustBeConsecutive.Validate(new List<char> { 'V', 'C', 'X', 'X', 'X', 'X' });

            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test5()
        {
            CountryBMustFollowCountryA mustBeConsecutive = new CountryBMustFollowCountryA('V', 'C', false);

            bool result = mustBeConsecutive.Validate(new List<char> { 'C', 'X', 'X', 'X', 'X', 'V' });

            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test6()
        {
            BlockConnection blockConnection = new BlockConnection('V', 'C', false);

            bool result = blockConnection.Validate(new List<char> { 'C', 'X', 'X', 'X', 'X', 'V' });

            Assert.AreEqual(false, result);
        }


        [Test]
        public void Test8()
        {
            List<char> route = new List<char> { 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M' };

            SeasonEvaluator seasonEvaluator = new SeasonEvaluator(new SeasonDataContainer());
            double eval = seasonEvaluator.Evaluate(route);


            Assert.AreEqual(37, eval);
        }



        [Test]
        public void Test9()
        {
            List<char> route = new List<char> { 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M' };
            SeasonEvaluator seasonEvaluator = new SeasonEvaluator(new SeasonDataContainer());
            double eval = seasonEvaluator.Evaluate(route);

            List<Tuple<char, string>> report = seasonEvaluator.Report(route);


            Assert.AreEqual(report.Count, 12);
        }

        [Test]
        public void TestFrontierService()
        {

            //Access Laos from Thailand
            var frontiers = frontierService.GetFrontiersByOriginAndFinalCountryCode('L', 'T');
            

            //NongKhai e Internacional
            //var frontier_airport = frontierService.FrontierstoAccesDestinationFromOriginIncludingAirports('L', 'T');
            Assert.AreEqual(true, frontiers.Count==2);

        }



        [Test]
        public void DetectRepeatedChars()
        {

            var decomposed = Helper.DetectRepeatedChars(new List<char> { 'T', 'T', 'M', 'M', 'M', 'M', 'T' });


            Assert.AreEqual(true, decomposed[0].Item1 == 'T');
            Assert.AreEqual(true, decomposed[1].Item1 == 'M');

            Assert.AreEqual(true, decomposed[0].Item2 == 3);
            Assert.AreEqual(true, decomposed[1].Item2 == 4);


        }


        [Test]
        public void DetectRepeatedCharsAllEqual()
        {

            var decomposed = Helper.DetectRepeatedChars(new List<char> { 'T', 'T', 'T', 'T', 'T', 'T', 'T' });


            Assert.AreEqual(true, decomposed[0].Item1 == 'T');

            Assert.AreEqual(true, decomposed[0].Item2 == 7);



        }

        [Test]
        public void DetectRepeatedCharsII()
        {

            var decomposed = Helper.DetectRepeatedChars(new List<char> { 'T', 'T', 'M', 'M', 'M', 'M', 'T', 'M' });


            Assert.AreEqual(true, decomposed[0].Item1 == 'T');
            Assert.AreEqual(true, decomposed[1].Item1 == 'M');
            Assert.AreEqual(true, decomposed[2].Item1 == 'T');
            Assert.AreEqual(true, decomposed[3].Item1 == 'M');

            Assert.AreEqual(true, decomposed[0].Item2 == 2);
            Assert.AreEqual(true, decomposed[1].Item2 == 4);
            Assert.AreEqual(true, decomposed[2].Item2 == 1);
            Assert.AreEqual(true, decomposed[3].Item2 == 1);


        }



        [Test]
        public void DetectRepeatedCharsIII()
        {

            List<char> route = new List<char> { 'M', 'M', 'M', 'T', 'M', 'M', 'M', 'T', 'T', 'T', 'T', 'T' };

            var decomposed = Helper.DetectRepeatedChars(route);

            Assert.AreEqual(true, decomposed[0].Item1 == 'M');
            Assert.AreEqual(true, decomposed[1].Item1 == 'T');
            Assert.AreEqual(true, decomposed[2].Item1 == 'M');
            Assert.AreEqual(true, decomposed[3].Item1 == 'T');

            Assert.AreEqual(true, decomposed[0].Item2 == 3);
            Assert.AreEqual(true, decomposed[1].Item2 == 1);
            Assert.AreEqual(true, decomposed[2].Item2 == 3);
            Assert.AreEqual(true, decomposed[3].Item2 == 5);
            Helper.DetectRepeatedChars(route);

        }
        [Test]
        public void NumberEntries()
        {

            List<Tuple<char, int>> NumberofEntries = Helper.CountNumberofEntries(new List<char> { 'T', 'T', 'M', 'M', 'M', 'M', 'T' });


            Assert.AreEqual(true, NumberofEntries[0].Item1 == 'T');
            Assert.AreEqual(true, NumberofEntries[1].Item1 == 'M');

            Assert.AreEqual(true, NumberofEntries[0].Item2 == 1);
            Assert.AreEqual(true, NumberofEntries[1].Item2 == 1);


        }

        [Test]
        public void NumberEntriesII()
        {

            var NumberofEntries = Helper.CountNumberofEntries(new List<char> { 'T', 'T', 'M', 'M', 'M', 'M', 'T', 'M' });


            Assert.AreEqual(true, NumberofEntries[0].Item1 == 'T');
            Assert.AreEqual(true, NumberofEntries[1].Item1 == 'M');


            Assert.AreEqual(true, NumberofEntries[0].Item2 == 2);
            Assert.AreEqual(true, NumberofEntries[1].Item2 == 2);



        }

        [Test]
        public void RouteValidation()
        {

            //Tailandia - Malasia - Malasia - Malasia - Tailandia - Malasia - Malasia - Malasia - Tailandia - Tailandia - Tailandia - Tailandia -

            List<char> route = new List<char> { 'T', 'M', 'M', 'M', 'T', 'M', 'M', 'M', 'T', 'T', 'T', 'T' };

            XXXMalasyaTailandiaLongStayRuleContainer malasyaTailandiaLongStayContainer = new XXXMalasyaTailandiaLongStayRuleContainer();
            RouteValidator routeValidator = new RouteValidator(malasyaTailandiaLongStayContainer.GetRules());


            var entries = Helper.CountNumberofEntries(route);

            var repeated = Helper.DetectRepeatedChars(route);

            foreach (var rule in malasyaTailandiaLongStayContainer.GetRules())
            {

                rule.Validate(route);

            }

            var BrokenRules = routeValidator.GetBrokenRules(new List<char> { 'T', 'M', 'M', 'M', 'T', 'M', 'M', 'M', 'T', 'T', 'T', 'T' });

            int count = BrokenRules.Count;


        }



        [Test]
        public void OneAnualConsecutiveStay()
        {

            List<char> route = new List<char> { 'T', 'T', 'M', 'M', 'M', 'T', 'T', 'M', 'M', 'X', 'X', 'X', 'T' };

            var decomposed = Helper.DetectRepeatedChars(route);


            OneStayYearWithXConsecutiveMonths oneStayYearWithXConsecutiveMonths = new OneStayYearWithXConsecutiveMonths('X', 3);
            var result = oneStayYearWithXConsecutiveMonths.Validate(route);

            Assert.AreEqual(true, result);


        }


        [Test]
        public void OneAnualNonConsecutiveStay()
        {

            List<char> route = new List<char> { 'T', 'T', 'M', 'M', 'M', 'X', 'T', 'M', 'M', 'X', 'X', 'T' };

            var decomposed = Helper.DetectRepeatedChars(route);


            OneStayYearWithXConsecutiveMonths oneStayYearWithXConsecutiveMonths = new OneStayYearWithXConsecutiveMonths('X', 3);
            var result = oneStayYearWithXConsecutiveMonths.Validate(route);

            Assert.AreEqual(false, result);


        }
    }
}