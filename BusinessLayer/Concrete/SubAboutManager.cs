using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class SubAboutManager:ISubAboutService
{
    ISubAboutDal _SubAboutDal;

    public SubAboutManager(ISubAboutDal subAboutDal)
    {
        _SubAboutDal = subAboutDal;
    }
    public void TAdd(SubAbout t)
    {
        throw new NotImplementedException();
    }

    public void TDelete(SubAbout t)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(SubAbout t)
    {
        throw new NotImplementedException();
    }

    public  List<SubAbout> TGetList()
    {
        return _SubAboutDal.GetList();
    }

    public SubAbout TGetById(int id)
    {
        throw new NotImplementedException();
    }
}