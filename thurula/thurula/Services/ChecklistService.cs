using MongoDB.Driver;
using thurula.Models;

namespace thurula.Services;

public class ChecklistService: IChecklistService
{
    private readonly IMongoCollection<Checklist> _checklists;

    public ChecklistService(IAtlasDbSettings settings, IMongoClient client)
    {
        var database = client.GetDatabase(settings.DatabaseName);
        _checklists = database.GetCollection<Checklist>("checklists");
    }

    public List<Checklist> Get() =>
        _checklists.Find(checklist => true).ToList();

    public Checklist Get(string id) =>
        _checklists.Find<Checklist>(checklist => checklist.Id == id).FirstOrDefault();


    public List<Checklist> GetAllNewborns()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Newborn").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Newborn").ToList();
    }

    public List<Checklist> GetAllWeek2()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Week2").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Week2").ToList();
    }

    public List<Checklist> GetAllWeek3()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Week3").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Week3").ToList();
    }

    public List<Checklist> GetAllMonth1()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Month1").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Month1").ToList();
    }

     public List<Checklist> GetAllWeek5()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Week5").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Week5").ToList();
    }

     public List<Checklist> GetAllWeek6()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Week6").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Week6").ToList();
    }

     public List<Checklist> GetAllWeek7()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Week7").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Week7").ToList();
    }

        public List<Checklist> GetAllMonth2()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Month2").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Month2").ToList();
    }

    public List<Checklist> GetAllWeek9()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Week9").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Week9").ToList();
    }

     public List<Checklist> GetAllWeek10()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Week10").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Week10").ToList();
    }

     public List<Checklist> GetAllWeek11()
    {
        List<Checklist>  check = _checklists.Find<Checklist>(checklist => checklist.Period == "Week11").ToList();
        // Console.WriteLine(check);
        check.ForEach(Console. WriteLine);
        return _checklists.Find<Checklist>(checklist => checklist.Period == "Week11").ToList();
    }

    public Checklist Create(Checklist checklist)
    {
        _checklists.InsertOne(checklist);
        return checklist;
    }
    // public void Update(string id, Baby babyIn) =>
    //     _babies.ReplaceOne(baby => baby.Id == id, babyIn);
    // public void Remove(Baby babyIn) =>
    //     _babies.DeleteOne(baby => baby.Id == babyIn.Id);
}