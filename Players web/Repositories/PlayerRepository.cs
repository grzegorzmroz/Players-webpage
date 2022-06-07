using Players_web.Models;
using Players_web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Players_web.Repositories
{
    public class PlayerRepository
    {
        public Player[] ReturnAllPlayers(int page = 1, int count = 5, string filter = null)
        {
            DataBaseModelDataContext db = new DataBaseModelDataContext();

            if (filter == null)
                return db.Players.Skip(count * (page - 1)).Take(count).ToArray();
            else
                return db.Players
                    .Where(x => x.name.Contains(filter) || x.surname.Contains(filter) || x.nationality.Contains(filter))
                    .Skip(count * (page - 1)).Take(count).ToArray();

        }
        public int ReturnPageCount(int count)
        {
            DataBaseModelDataContext db = new DataBaseModelDataContext();
            int pageCount = Convert.ToInt32(Math.Ceiling(db.Players.Count() / Convert.ToDouble(count)));
            return pageCount;
        }
        public Player ReturnPlayer(int id)
        {
            DataBaseModelDataContext db = new DataBaseModelDataContext();
            return db.Players.FirstOrDefault(x => x.player_id == id);
        }
        public void EditPlayer(int id, string name, string surname, string nationality, DateTime bithDate, int height, int weight)
        {
            DataBaseModelDataContext db = new DataBaseModelDataContext();
            var player = db.Players.FirstOrDefault(x => x.player_id == id);
            player.name = name;
            player.surname = surname;
            player.nationality = nationality;
            player.birth_date = bithDate;
            player.height = height;
            player.weight = weight;
            db.SubmitChanges();
        }
        public void DeletePlayer(int id)
        {
            DataBaseModelDataContext db = new DataBaseModelDataContext();
            var player = db.Players.FirstOrDefault(x => x.player_id == id);
            db.Players.DeleteOnSubmit(player);
            db.SubmitChanges();
        }

        public void AddPlayer(string name, string surname, string nationality, DateTime birtDate, int height, int weight)
        {
            DataBaseModelDataContext db = new DataBaseModelDataContext();
            Player player = new Player();
            player.name = name;
            player.surname = surname;
            player.nationality = nationality;
            player.birth_date = birtDate;
            player.height = height;
            player.weight = weight;
            db.Players.InsertOnSubmit(player);
            db.SubmitChanges();
        }
    }
}