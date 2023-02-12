using Microsoft.EntityFrameworkCore;
using VoitureApi.Model;
using VoitureAPi2.Model;

namespace VoitureAPi2.Services
{
    public class EvenementService : IEvenement
    {
        MyDatabaseContext myDatabase;
        public EvenementService(MyDatabaseContext myDatabase)
        {
            this.myDatabase = myDatabase;
        }
        public async Task<Evenement> addUpdateEvent(Evenement evenement)
        {
            if (evenement == null)
                throw new Exception("Categorie null");
            if (evenement.Id == 0)
                myDatabase.evenements.Add(evenement);
            else
                myDatabase.evenements.Update(evenement);
             myDatabase.SaveChanges();
            return evenement;
        }

        public async Task<IEnumerable<Evenement>> getAllEvenement()
        {
            return await myDatabase.evenements.ToListAsync();
        }

        public async Task<Evenement> getEvenement(int id)
        {
            Evenement e = await myDatabase.evenements.FirstOrDefaultAsync(x => x.Id == id);
            if (e == null)
                throw new Exception("Not found");
            return e;
        }

        public void removeEvent(Evenement Event)
        {
            myDatabase.evenements.Remove(Event);
            myDatabase.SaveChanges();
        }
    }
}
