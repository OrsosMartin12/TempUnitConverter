namespace TestUnite;
using System;
using TempUnitConverter;
using Xunit;

public class UnitTest1
{
    //convert osztály példányositása
    Converter converter = new Converter();

    //Teszt ami egy értékkel megnézi hogy hejes értékkel tér-e vissza
    [Fact]
    public void CToKTestShouldReturnFifty()
    {
        Assert.Equal(283.15, converter.CToK(10));
    }

    //Teszt ami egy értékkel megnézi hogy hejes értékkel tér-e vissza
    [Fact]
    public void CToFTestShouldReturnDouble()
    {
        Assert.Equal(283.14999999999998, converter.CToK(10));
    }

    //Teszt ami egy értékkel megnézi hogy hejes értékkel tér-e vissza
    [Fact]
    public void KToCTestShouldReturnZero()
    {
        Assert.Equal(-273.15, converter.KToC(0));
    }

    //Teszt ami egy értékkel megnézi hogy hejes értékkel tér-e vissza
    [Fact]
    public void KToFTestShouldReturnZero()
    {
        Assert.Equal(-459.67, converter.KToF(0));
    }

    //Teszt ami egy értékkel megnézi hogy hejes értékkel tér-e vissza
    [Fact]
    public void FToCTestShouldReturnMinusztizenhét()
    {
        Assert.Equal(-17.78, Math.Round(converter.FToC(0),2));
    }

    //Teszt ami egy értékkel megnézi hogy hejes értékkel tér-e vissza
    [Fact]
    public void FToKTestShouldReturnKetöszázhuzonkettö()
    {
        Assert.Equal(255, Math.Round(converter.FToK(0)));
    }

    //Teszt ami több értékkel megnézi hogy hejes értékkel tér-e vissza
    [Theory]
    [InlineData(273.15, 0)]
    [InlineData(283.15, 10)]
    [InlineData(373.15, 100)]

    public void CToKTestShouldReturnDouble(double value1, double value2)
    {
        Assert.Equal(value1, Math.Round(converter.CToK(value2),2));
    }
}



