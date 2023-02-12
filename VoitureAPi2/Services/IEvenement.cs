using VoitureAPi2.Model;

namespace VoitureAPi2.Services
{
    public interface IEvenement
    {
        Task<Evenement> addUpdateEvent(Evenement evenement);
        void removeEvent(Evenement Event);
        Task<Evenement> getEvenement(int id);
        Task<IEnumerable<Evenement>> getAllEvenement();
    }
}
