using FootballManagerApi.Data;
using FootballManagerApi.ServiceAbstracts;
using System.Threading.Tasks;

namespace FootballManagerApi.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ITeamService teamService, IFootballerService footballerService, ICoachService coachService, IManagementPositionService managementPositionService, INationalTeamService nationalTeamService, IPositionService positionService, ITacticService tacticService, IManagerService managerService, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            this.FootballerService = footballerService;
            this.TeamService = teamService;
            this.ManagerService = managerService;
            this.NationalTeamService = nationalTeamService;
            this.ManagementPositionService = managementPositionService;
            this.PositionService = positionService;
            this.ManagerService = managerService;
            this.TacticService = tacticService;
        }

        public ITeamService TeamService { get; set; }
        public IFootballerService FootballerService { get; set; }
        public ICoachService CoachService { get; set; }
        public IManagementPositionService ManagementPositionService { get; set; }
        public INationalTeamService NationalTeamService { get; set; }
        public IPositionService PositionService { get; set; }
        public ITacticService TacticService { get; set; }
        public IManagerService ManagerService { get; set; }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
