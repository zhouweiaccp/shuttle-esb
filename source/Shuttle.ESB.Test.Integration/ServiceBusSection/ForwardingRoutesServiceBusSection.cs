using System;
using NUnit.Framework;
using Shuttle.ESB.Core;

namespace Shuttle.ESB.Test.Integration
{
    [TestFixture]
    public class ForwardingRoutesServiceBusSection : ServiceBusSectionFixture
    {
        [Test]
        public void Should_be_able_to_load_the_configuration()
        {
            var section = GetServiceBusSection("ForwardingRoutes.config");

            Assert.IsNotNull(section);
            Assert.AreEqual(2, section.ForwardingRoutes.Count);

			foreach (MessageRouteElement map in section.ForwardingRoutes)
            {
                Console.WriteLine(map.Uri);

                foreach (SpecificationElement specification in map)
                {
                    Console.WriteLine("-> {0} - {1}", specification.Name, specification.Value);
                }
                
                Console.WriteLine();
            }
        }
    }
}