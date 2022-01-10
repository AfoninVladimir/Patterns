using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    string autor;
    string name;
    string genre;
    int id;
    public Book(string autor, string name, string genre, int id)
    {
        this.autor = autor;
        this.name = name;
        this.id = id;
        this.genre = genre;
    }
    
    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }
    public string Name 
    {
        get { return name; } 
        set { name = value; }
    }
    public string Genre 
    {
        get { return genre; }
        set { genre = value; }
    }
    public int ID 
    {
        get { return id; } 
        set { id = value; }
    }
}