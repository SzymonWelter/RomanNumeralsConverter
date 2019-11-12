namespace RomanNumeralsConverter
{
    public interface IConverter<TFrom,TTo>
    {
        TTo Convert(TFrom source);
    }
}