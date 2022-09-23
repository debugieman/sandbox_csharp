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
    protected string SendByUserName { get; set; }   
    protected bool IsPublic { get; set; }
    public Post()
    { 
        ID = 0;
        Title = "My first obj";
        SendByUserName = "Me";
        IsPublic = true;
    }




}
