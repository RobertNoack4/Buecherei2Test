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
            Assert.That(Pruefungen.EingabeZahlPruefung("2"), Is.True);
        }

        [Test]
        [TestCase("a")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void EingabeZahlPruefung_KeineZahlWirdEingegeben_ReturnFalse(string eingabe)
        {
            Assert.That(Pruefungen.EingabeZahlPruefung(eingabe), Is.False);
        }

        [Test]
        public void EingabeZahlIstOption_EingabeKleinerAls1_ReturnFalse()
        {
            Assert.That(Pruefungen.EingabeZahlIstOption(0, 3), Is.False);
        }

        [Test]
        public void EingabeZahlIstOption_EingabeGroeßerAlsMoeglichkeiten_ReturnFalse()
        {
            Assert.That(Pruefungen.EingabeZahlIstOption(4, 3), Is.False);
        }

        [Test]
        public void EingabeZahlIstOption_EingabekleinerAlsMoeglichkeitenUndGroeßerAlsNull_ReturnTrue()
        {
            Assert.That(Pruefungen.EingabeZahlIstOption(1, 3), Is.True);
        }

        [Test]
        public void JaNeinTest_InputYkeyPress_ReturnTrue()
        {
            Assert.That(Pruefungen.JaNeinTest(ConsoleKey.Y), Is.True);
        }

        [Test]
        public void JaNeinTest_InputNkeyPress_ReturnTrue()
        {
            Assert.That(Pruefungen.JaNeinTest(ConsoleKey.N), Is.False);
        }

        [Test]
        public void JaNeinTest_InputOtherkeyPress_ReturnTrue()
        {
            Assert.That(() => Pruefungen.JaNeinTest(ConsoleKey.O), Throws.ArgumentException);
        }
    }
}
