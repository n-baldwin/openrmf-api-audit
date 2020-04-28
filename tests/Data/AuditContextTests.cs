using openrmf_audit_api.Data;
using openrmf_audit_api.Models;
using Microsoft.Extensions.Options;
using Xunit;

namespace tests.Data
{
    public class AuditContextTests
    {
        private readonly AuditContext _auditContext;

        public AuditContextTests()
        {
            Settings settings = new Settings();
            
            settings.ConnectionString = "mongodb://openrmf:openrmf1234!@localhost/openrmf?authSource=admin";
            settings.Database = "openrmf";

            _auditContext = new AuditContext(Options.Create<Settings>(settings));
        }

        [Fact]
        public void Test_AuditContextIsValid()
        {
            // Testing
            Assert.False(_auditContext == null);
            Assert.False(_auditContext.Audits == null);
        }
    }
}
