using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostProjectID;

public  class Post
   

{
    private static int currentPostId;

    //properties
    protected int ID { get; set; }
    protected string Title { get; set; }
    public string? SendByUsername { get;}
    public string SendByUserName { get; set; }   
    public bool IsPublic { get; set; }
    public Post()
    { 
        ID = 0;
        Title = "My first obj";
        SendByUserName = "Meeeeeeeeee123";
        IsPublic = true;


    }
    public Post(string title, bool IsPublic, string sendByUserName)
    {
        this.ID = 0;
        this.Title = title;
        this.SendByUsername = SendByUserName;
        this.IsPublic = IsPublic;
    }

    protected int GetNextID()
    { 
    return ++currentPostId +1 ;
    }

    public void update(string title, bool isPublic)
    {
        this.Title = title;
        this.IsPublic= isPublic;
    }


    public override string ToString()
    {
        return String.Format($"{this.ID}  ---   {this.Title} --by-- {this.SendByUserName}");
    }



}

