using Builder.Models;

namespace Builder.HouseBuilder.Abstraction
{
    public interface IHouseBuilder
    {
        void SetBasicInfo();
        void LayFoundations();
        void BuildWalls();
        void FitWindows();
        void BuildRoof();
        House GetResult();
        void GetInfo();
        void BuildExtras();
        void Reset();
    }
}
