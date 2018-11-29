using System.Collections.Generic;
using System;

namespace CDOrganizer.Models
{
    public class Artist
    {
        private static List<Artist> _instances = new List<Artist> {};
        private string _name;
        private int _id;
        private List<CD> _cds;

        public Artist(string artistName)
        {
            _name = artistName;
            _instances.Add(this);
            _id = _instances.Count;
            _cds = new List<CD>{};
        }

        public string GetName()
        {
            return _name;
        }

        public int GetId()
        {
            return _id;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Artist> GetAll()
        {
            return _instances;
        }

        public static void SetAll(List<Artist> tempList)
        {
            Artist._instances = tempList;
        }

        public static Artist Find(int searchId)
        {
            return _instances[searchId-1];
        }
        
        public static Artist FindByName(string artistName)
        {
            string temp = "";
            Artist artistTemp = new Artist(temp);
            foreach(Artist artist in _instances)
            {
                if (artistName == artist.GetName())
                {
                    artistTemp = artist;
                }
            }
            return artistTemp;


        }

        public List<CD> GetCDs()
        {
            return _cds;
        }

        public void AddCD(CD cd)
        {
            _cds.Add(cd);
        }

        public static void RemoveError(string tempName)
        {
            foreach (Artist artist in _instances)
            {
                if (artist.GetName() == tempName)
                {
                    int tempId = artist.GetId();
                    Console.WriteLine(_instances.Count);
                    _instances.RemoveAt(tempId - 1);
                    Console.WriteLine(_instances.Count);
                }
            }
        }


    }
}