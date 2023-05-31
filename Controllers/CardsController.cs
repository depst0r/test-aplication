using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace testapp.Controllers;

public class Photo
{
    public string? photo;
    public string? thumbnail;
}

public class Item
{
    public int id;
    public string? title;
    public string? header;
    public string? description;
    public string? periodStart;
    public string? periodEnd;
    public string? minPrice;
    public Photo? photoCard;
    public IList<Photo>? photoAlbum;
    public string[]? route;
}

[ApiController]
[Route("[controller]")]
public class CardsController : ControllerBase
{
    private string LoadJson()
    {
        StreamReader JsonFile = new StreamReader("data.json");
        return JsonFile.ReadToEnd();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(LoadJson());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var Items = JsonConvert.DeserializeObject<List<Item>>(LoadJson());
        var item = Items.First(item => item.id == id);

        var roundTrippedJson = JsonConvert.SerializeObject(item);

        return Ok(roundTrippedJson);
    }
}
