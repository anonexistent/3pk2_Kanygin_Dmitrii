﻿using System.Collections.Generic;
using System.Windows.Documents;

namespace pz_010.Backroll;

class Album
{
    public Stack<Photo> photos { get; set; }
    //{ get { if (photos.Count < 1) LastPhoto(); return photos; } set { photos = value; } }
    
    public Album()
    {
        photos = new Stack<Photo>();
    }

    private Stack<Photo> LastPhoto()
    {
        if(photos.Count<1) photos.Push(new Photo(new FlowDocument(null)));
        return photos;
    }
}