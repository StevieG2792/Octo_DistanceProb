namespace DistanceProb_API.Interface
{
    public interface IConvertToUom
    {
        public double Convert(IUnitsOfMeasurement method, double distance);
    }
}
