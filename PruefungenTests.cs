using NUnit.Framework;
using Buecherei.Properties;
using Moq;
using System;

namespace Buecherei.UnitTests
{
    [TestFixture]
    public class PruefungenTests
    {
        [Test]
        public void EingabeZahlPruefung_ZahlWirdEingegeben_ReturnTrue()
        {
            var result = Pruefungen.EingabeZahlPruefung("2");

            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("a")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void EingabeZahlPruefung_KeineZahlWirdEingegeben_ReturnFalse(string eingabe)
        {
            var result = Pruefungen.EingabeZahlPruefung(eingabe);

            Assert.That(result, Is.False);
        }

        [Test]
        public void EingabeZahlIstOption_EingabeKleinerAls1_ReturnFalse()
        {
            var result = Pruefungen.EingabeZahlIstOption(0, 3);

            Assert.That(result, Is.False);
        }

        [Test]
        public void EingabeZahlIstOption_EingabeGroeßerAlsMoeglichkeiten_ReturnFalse()
        {
            var result = Pruefungen.EingabeZahlIstOption(4, 3);

            Assert.That(result, Is.False);
        }

        [Test]
        public void EingabeZahlIstOption_EingabekleinerAlsMoeglichkeitenUndGroeßerAlsNull_ReturnTrue()
        {
            var result = Pruefungen.EingabeZahlIstOption(1, 3);

            Assert.That(result, Is.True);
        }


    }
}
