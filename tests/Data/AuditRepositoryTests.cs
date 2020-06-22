using openrmf_audit_api.Data;
using openrmf_audit_api.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Xunit;

namespace tests.Data
{
    public class AuditRepositoryTests
    {
        private readonly AuditRepository _auditRepository;

        public AuditRepositoryTests()
        {
            Settings settings = new Settings();

            settings.ConnectionString = "mongodb://openrmf:openrmf1234!@localhost/openrmf?authSource=admin";
            settings.Database = "openrmf";

            _auditRepository = new AuditRepository(Options.Create<Settings>(settings));
        }

        [Fact]
        public async Task Test_AuditRepositoryIsValid()
        {
            Assert.False(_auditRepository == null);

            // Testing
            /*
            await _auditRepository.GetAllAudits();
            await _auditRepository.GetAudit("someid");
            */
        }
    }
}
