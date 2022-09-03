using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AqInternetAgent> AqInternetAgents { get; set; }
        public virtual DbSet<AqInternetAgentPriv> AqInternetAgentPrivs { get; set; }
        public virtual DbSet<AqKeyShardMap> AqKeyShardMaps { get; set; }
        public virtual DbSet<AqQueue> AqQueues { get; set; }
        public virtual DbSet<AqQueueTable> AqQueueTables { get; set; }
        public virtual DbSet<AqSchedule> AqSchedules { get; set; }
        public virtual DbSet<DatabaseAsd> DatabaseAsds { get; set; }
        public virtual DbSet<DatabaseCaserecord> DatabaseCaserecords { get; set; }
        public virtual DbSet<DatabaseCourier> DatabaseCouriers { get; set; }
        public virtual DbSet<DatabaseDemandform> DatabaseDemandforms { get; set; }
        public virtual DbSet<DatabaseDonatetounit> DatabaseDonatetounits { get; set; }
        public virtual DbSet<DatabaseDonor> DatabaseDonors { get; set; }
        public virtual DbSet<DatabaseDonorpurchase> DatabaseDonorpurchases { get; set; }
        public virtual DbSet<DatabaseEpidemiccontrolunit> DatabaseEpidemiccontrolunits { get; set; }
        public virtual DbSet<DatabaseGood> DatabaseGoods { get; set; }
        public virtual DbSet<DatabaseIsolatedpoint> DatabaseIsolatedpoints { get; set; }
        public virtual DbSet<DatabaseIsolationassign> DatabaseIsolationassigns { get; set; }
        public virtual DbSet<DatabaseManage> DatabaseManages { get; set; }
        public virtual DbSet<DatabaseMedicalresource> DatabaseMedicalresources { get; set; }
        public virtual DbSet<DatabasePerson> DatabasePerson { get; set; }
        public virtual DbSet<DatabaseRiskingarea> DatabaseRiskingareas { get; set; }
        public virtual DbSet<DatabaseSampling> DatabaseSamplings { get; set; }
        public virtual DbSet<DatabaseStaff> DatabaseStaffs { get; set; }
        public virtual DbSet<DatabaseTestinfo> DatabaseTestinfos { get; set; }
        public virtual DbSet<DatabaseTestingcenter> DatabaseTestingcenters { get; set; }
        public virtual DbSet<DatabaseTestingcenterassignment> DatabaseTestingcenterassignments { get; set; }
        public virtual DbSet<DatabaseTestinginstitution> DatabaseTestinginstitutions { get; set; }
        public virtual DbSet<DatabaseTrajectory> DatabaseTrajectories { get; set; }
        public virtual DbSet<DatabaseTransport> DatabaseTransports { get; set; }
        public virtual DbSet<DatabaseUnitspurchase> DatabaseUnitspurchases { get; set; }
        public virtual DbSet<DatabaseUser> DatabaseUsers { get; set; }
        public virtual DbSet<DatabaseViewdemandform> DatabaseViewdemandforms { get; set; }
        public virtual DbSet<DatabaseVolunteer> DatabaseVolunteers { get; set; }
        public virtual DbSet<DatabaseWritedemandform> DatabaseWritedemandforms { get; set; }
        public virtual DbSet<Help> Helps { get; set; }
        public virtual DbSet<LogmnrAgeSpill> LogmnrAgeSpills { get; set; }
        public virtual DbSet<LogmnrAttrcol> LogmnrAttrcols { get; set; }
        public virtual DbSet<LogmnrAttribute> LogmnrAttributes { get; set; }
        public virtual DbSet<LogmnrCcol> LogmnrCcols { get; set; }
        public virtual DbSet<LogmnrCdef> LogmnrCdefs { get; set; }
        public virtual DbSet<LogmnrCol> LogmnrCols { get; set; }
        public virtual DbSet<LogmnrColtype> LogmnrColtypes { get; set; }
        public virtual DbSet<LogmnrCon> LogmnrCons { get; set; }
        public virtual DbSet<LogmnrContainer> LogmnrContainers { get; set; }
        public virtual DbSet<LogmnrDictionary> LogmnrDictionaries { get; set; }
        public virtual DbSet<LogmnrDictstate> LogmnrDictstates { get; set; }
        public virtual DbSet<LogmnrDid> LogmnrDids { get; set; }
        public virtual DbSet<LogmnrEnc> LogmnrEncs { get; set; }
        public virtual DbSet<LogmnrError> LogmnrErrors { get; set; }
        public virtual DbSet<LogmnrFilter> LogmnrFilters { get; set; }
        public virtual DbSet<LogmnrGlobal> LogmnrGlobals { get; set; }
        public virtual DbSet<LogmnrGtTabInclude> LogmnrGtTabIncludes { get; set; }
        public virtual DbSet<LogmnrGtUserInclude> LogmnrGtUserIncludes { get; set; }
        public virtual DbSet<LogmnrGtXidInclude> LogmnrGtXidIncludes { get; set; }
        public virtual DbSet<LogmnrIcol> LogmnrIcols { get; set; }
        public virtual DbSet<LogmnrIdnseq> LogmnrIdnseqs { get; set; }
        public virtual DbSet<LogmnrInd> LogmnrInds { get; set; }
        public virtual DbSet<LogmnrIndcompart> LogmnrIndcomparts { get; set; }
        public virtual DbSet<LogmnrIndpart> LogmnrIndparts { get; set; }
        public virtual DbSet<LogmnrIndsubpart> LogmnrIndsubparts { get; set; }
        public virtual DbSet<LogmnrKopm> LogmnrKopms { get; set; }
        public virtual DbSet<LogmnrLob> LogmnrLobs { get; set; }
        public virtual DbSet<LogmnrLobfrag> LogmnrLobfrags { get; set; }
        public virtual DbSet<LogmnrLog> LogmnrLogs { get; set; }
        public virtual DbSet<LogmnrLogmnrBuildlog> LogmnrLogmnrBuildlogs { get; set; }
        public virtual DbSet<LogmnrNtab> LogmnrNtabs { get; set; }
        public virtual DbSet<LogmnrObj> LogmnrObjs { get; set; }
        public virtual DbSet<LogmnrOpqtype> LogmnrOpqtypes { get; set; }
        public virtual DbSet<LogmnrParameter> LogmnrParameters { get; set; }
        public virtual DbSet<LogmnrPartobj> LogmnrPartobjs { get; set; }
        public virtual DbSet<LogmnrPdbInfo> LogmnrPdbInfos { get; set; }
        public virtual DbSet<LogmnrProcessedLog> LogmnrProcessedLogs { get; set; }
        public virtual DbSet<LogmnrProfilePlsqlStat> LogmnrProfilePlsqlStats { get; set; }
        public virtual DbSet<LogmnrProfileTableStat> LogmnrProfileTableStats { get; set; }
        public virtual DbSet<LogmnrProp> LogmnrProps { get; set; }
        public virtual DbSet<LogmnrRefcon> LogmnrRefcons { get; set; }
        public virtual DbSet<LogmnrRestartCkpt> LogmnrRestartCkpts { get; set; }
        public virtual DbSet<LogmnrRestartCkptTxinfo> LogmnrRestartCkptTxinfos { get; set; }
        public virtual DbSet<LogmnrSeed> LogmnrSeeds { get; set; }
        public virtual DbSet<LogmnrSession> LogmnrSessions { get; set; }
        public virtual DbSet<LogmnrSessionAction> LogmnrSessionActions { get; set; }
        public virtual DbSet<LogmnrSessionEvolve> LogmnrSessionEvolves { get; set; }
        public virtual DbSet<LogmnrShardT> LogmnrShardTs { get; set; }
        public virtual DbSet<LogmnrSpill> LogmnrSpills { get; set; }
        public virtual DbSet<LogmnrSubcoltype> LogmnrSubcoltypes { get; set; }
        public virtual DbSet<LogmnrT> LogmnrTs { get; set; }
        public virtual DbSet<LogmnrTab> LogmnrTabs { get; set; }
        public virtual DbSet<LogmnrTabcompart> LogmnrTabcomparts { get; set; }
        public virtual DbSet<LogmnrTabpart> LogmnrTabparts { get; set; }
        public virtual DbSet<LogmnrTabsubpart> LogmnrTabsubparts { get; set; }
        public virtual DbSet<LogmnrType> LogmnrTypes { get; set; }
        public virtual DbSet<LogmnrUid> LogmnrUids { get; set; }
        public virtual DbSet<LogmnrUser> LogmnrUsers { get; set; }
        public virtual DbSet<LogmnrcConGg> LogmnrcConGgs { get; set; }
        public virtual DbSet<LogmnrcConcolGg> LogmnrcConcolGgs { get; set; }
        public virtual DbSet<LogmnrcDbnameUidMap> LogmnrcDbnameUidMaps { get; set; }
        public virtual DbSet<LogmnrcGsba> LogmnrcGsbas { get; set; }
        public virtual DbSet<LogmnrcGsii> LogmnrcGsiis { get; set; }
        public virtual DbSet<LogmnrcGtc> LogmnrcGtcs { get; set; }
        public virtual DbSet<LogmnrcGtlo> LogmnrcGtlos { get; set; }
        public virtual DbSet<LogmnrcIndGg> LogmnrcIndGgs { get; set; }
        public virtual DbSet<LogmnrcIndcolGg> LogmnrcIndcolGgs { get; set; }
        public virtual DbSet<LogmnrcSeqGg> LogmnrcSeqGgs { get; set; }
        public virtual DbSet<LogmnrcShardT> LogmnrcShardTs { get; set; }
        public virtual DbSet<LogmnrcT> LogmnrcTs { get; set; }
        public virtual DbSet<LogmnrcTspart> LogmnrcTsparts { get; set; }
        public virtual DbSet<LogmnrggcGtc> LogmnrggcGtcs { get; set; }
        public virtual DbSet<LogmnrggcGtlo> LogmnrggcGtlos { get; set; }
        public virtual DbSet<LogmnrpCtasPartMap> LogmnrpCtasPartMaps { get; set; }
        public virtual DbSet<LogmnrtMddl> LogmnrtMddls { get; set; }
        public virtual DbSet<LogstdbyApplyMilestone> LogstdbyApplyMilestones { get; set; }
        public virtual DbSet<LogstdbyApplyProgress> LogstdbyApplyProgresses { get; set; }
        public virtual DbSet<LogstdbyEdsTable> LogstdbyEdsTables { get; set; }
        public virtual DbSet<LogstdbyEvent> LogstdbyEvents { get; set; }
        public virtual DbSet<LogstdbyFlashbackScn> LogstdbyFlashbackScns { get; set; }
        public virtual DbSet<LogstdbyHistory> LogstdbyHistories { get; set; }
        public virtual DbSet<LogstdbyParameter> LogstdbyParameters { get; set; }
        public virtual DbSet<LogstdbyPlsql> LogstdbyPlsqls { get; set; }
        public virtual DbSet<LogstdbyScn> LogstdbyScns { get; set; }
        public virtual DbSet<LogstdbySkip> LogstdbySkips { get; set; }
        public virtual DbSet<LogstdbySkipSupport> LogstdbySkipSupports { get; set; }
        public virtual DbSet<LogstdbySkipTransaction> LogstdbySkipTransactions { get; set; }
        public virtual DbSet<MviewAdvAjg> MviewAdvAjgs { get; set; }
        public virtual DbSet<MviewAdvBasetable> MviewAdvBasetables { get; set; }
        public virtual DbSet<MviewAdvClique> MviewAdvCliques { get; set; }
        public virtual DbSet<MviewAdvEligible> MviewAdvEligibles { get; set; }
        public virtual DbSet<MviewAdvException> MviewAdvExceptions { get; set; }
        public virtual DbSet<MviewAdvFilter> MviewAdvFilters { get; set; }
        public virtual DbSet<MviewAdvFilterinstance> MviewAdvFilterinstances { get; set; }
        public virtual DbSet<MviewAdvFjg> MviewAdvFjgs { get; set; }
        public virtual DbSet<MviewAdvGc> MviewAdvGcs { get; set; }
        public virtual DbSet<MviewAdvInfo> MviewAdvInfos { get; set; }
        public virtual DbSet<MviewAdvJournal> MviewAdvJournals { get; set; }
        public virtual DbSet<MviewAdvLevel> MviewAdvLevels { get; set; }
        public virtual DbSet<MviewAdvLog> MviewAdvLogs { get; set; }
        public virtual DbSet<MviewAdvOutput> MviewAdvOutputs { get; set; }
        public virtual DbSet<MviewAdvParameter> MviewAdvParameters { get; set; }
        public virtual DbSet<MviewAdvPlan> MviewAdvPlans { get; set; }
        public virtual DbSet<MviewAdvPretty> MviewAdvPretties { get; set; }
        public virtual DbSet<MviewAdvRollup> MviewAdvRollups { get; set; }
        public virtual DbSet<MviewAdvSqldepend> MviewAdvSqldepends { get; set; }
        public virtual DbSet<MviewAdvTemp> MviewAdvTemps { get; set; }
        public virtual DbSet<MviewAdvWorkload> MviewAdvWorkloads { get; set; }
        public virtual DbSet<MviewEvaluation> MviewEvaluations { get; set; }
        public virtual DbSet<MviewException> MviewExceptions { get; set; }
        public virtual DbSet<MviewFilter> MviewFilters { get; set; }
        public virtual DbSet<MviewFilterinstance> MviewFilterinstances { get; set; }
        public virtual DbSet<MviewLog> MviewLogs { get; set; }
        public virtual DbSet<MviewRecommendation> MviewRecommendations { get; set; }
        public virtual DbSet<MviewWorkload> MviewWorkloads { get; set; }
        public virtual DbSet<Ol> Ols { get; set; }
        public virtual DbSet<OlHint> OlHints { get; set; }
        public virtual DbSet<OlNode> OlNodes { get; set; }
        public virtual DbSet<ProductPriv> ProductPrivs { get; set; }
        public virtual DbSet<RedoDb> RedoDbs { get; set; }
        public virtual DbSet<RedoLog> RedoLogs { get; set; }
        public virtual DbSet<RollingConnection> RollingConnections { get; set; }
        public virtual DbSet<RollingDatabase> RollingDatabases { get; set; }
        public virtual DbSet<RollingDirective> RollingDirectives { get; set; }
        public virtual DbSet<RollingEvent> RollingEvents { get; set; }
        public virtual DbSet<RollingParameter> RollingParameters { get; set; }
        public virtual DbSet<RollingPlan> RollingPlans { get; set; }
        public virtual DbSet<RollingStatistic> RollingStatistics { get; set; }
        public virtual DbSet<RollingStatus> RollingStatuses { get; set; }
        public virtual DbSet<SchedulerJobArg> SchedulerJobArgs { get; set; }
        public virtual DbSet<SchedulerJobArgsTbl> SchedulerJobArgsTbls { get; set; }
        public virtual DbSet<SchedulerProgramArg> SchedulerProgramArgs { get; set; }
        public virtual DbSet<SchedulerProgramArgsTbl> SchedulerProgramArgsTbls { get; set; }
        public virtual DbSet<SqlplusProductProfile> SqlplusProductProfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Data Source=121.205.88.204/ORCLCDB;Password=123456;User ID=system;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<AqInternetAgent>(entity =>
            {
                entity.HasKey(e => e.AgentName)
                    .HasName("SYS_C002346");

                entity.ToTable("AQ$_INTERNET_AGENTS");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("AGENT_NAME");

                entity.Property(e => e.Protocol)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PROTOCOL");

                entity.Property(e => e.Spare1)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SPARE1");
            });

            modelBuilder.Entity<AqInternetAgentPriv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AQ$_INTERNET_AGENT_PRIVS");

                entity.HasIndex(e => new { e.AgentName, e.DbUsername }, "UNQ_PAIRS")
                    .IsUnique();

                entity.Property(e => e.AgentName)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("AGENT_NAME");

                entity.Property(e => e.DbUsername)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("DB_USERNAME");

                entity.HasOne(d => d.AgentNameNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.AgentName)
                    .HasConstraintName("AGENT_MUST_BE_CREATED");
            });

            modelBuilder.Entity<AqKeyShardMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AQ$_KEY_SHARD_MAP");

                entity.HasIndex(e => new { e.Queue, e.Key }, "AQ$_KEY_SHARD_MAP_PK")
                    .IsUnique();

                entity.Property(e => e.DelayShard)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELAY_SHARD");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("KEY");

                entity.Property(e => e.Queue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUEUE");

                entity.Property(e => e.Shard)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SHARD");
            });

            modelBuilder.Entity<AqQueue>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("AQ$_QUEUES_PRIMARY");

                entity.ToTable("AQ$_QUEUES");

                entity.HasIndex(e => new { e.Name, e.TableObjno }, "AQ$_QUEUES_CHECK")
                    .IsUnique();

                entity.HasIndex(e => new { e.Name, e.Eventid, e.TableObjno }, "I1_QUEUES");

                entity.Property(e => e.Oid)
                    .ValueGeneratedNever()
                    .HasColumnName("OID");

                entity.Property(e => e.BaseQueue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASE_QUEUE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EnableFlag)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENABLE_FLAG");

                entity.Property(e => e.Eventid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EVENTID");

                entity.Property(e => e.MaxRetries)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MAX_RETRIES");

                entity.Property(e => e.MemoryThreshold)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MEMORY_THRESHOLD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.NetworkName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NETWORK_NAME");

                entity.Property(e => e.Properties)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTIES");

                entity.Property(e => e.QueueComment)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("QUEUE_COMMENT");

                entity.Property(e => e.RetTime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RET_TIME");

                entity.Property(e => e.RetryDelay)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RETRY_DELAY");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE_NAME");

                entity.Property(e => e.Sharded)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SHARDED");

                entity.Property(e => e.SubOid).HasColumnName("SUB_OID");

                entity.Property(e => e.TableObjno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TABLE_OBJNO");

                entity.Property(e => e.Usage)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USAGE");
            });

            modelBuilder.Entity<AqQueueTable>(entity =>
            {
                entity.HasKey(e => e.Objno)
                    .HasName("AQ$_QUEUE_TABLES_PRIMARY");

                entity.ToTable("AQ$_QUEUE_TABLES");

                entity.HasIndex(e => new { e.Objno, e.Schema, e.Flags }, "I1_QUEUE_TABLES");

                entity.Property(e => e.Objno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJNO");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Schema)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SCHEMA");

                entity.Property(e => e.SortCols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SORT_COLS");

                entity.Property(e => e.TableComment)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_COMMENT");

                entity.Property(e => e.Timezone)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("TIMEZONE");

                entity.Property(e => e.UdataType)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UDATA_TYPE");
            });

            modelBuilder.Entity<AqSchedule>(entity =>
            {
                entity.HasKey(e => new { e.Oid, e.Destination })
                    .HasName("AQ$_SCHEDULES_PRIMARY");

                entity.ToTable("AQ$_SCHEDULES");

                entity.HasIndex(e => e.Jobno, "AQ$_SCHEDULES_CHECK")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Destination)
                    .HasMaxLength(390)
                    .IsUnicode(false)
                    .HasColumnName("DESTINATION");

                entity.Property(e => e.Duration)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DURATION");

                entity.Property(e => e.Jobno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("JOBNO");

                entity.Property(e => e.LastTime)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_TIME");

                entity.Property(e => e.Latency)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LATENCY");

                entity.Property(e => e.NextTime)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("NEXT_TIME");

                entity.Property(e => e.StartTime)
                    .HasColumnType("DATE")
                    .HasColumnName("START_TIME");
            });

            modelBuilder.Entity<DatabaseAsd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DATABASE_ASD");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Isolationspotname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISOLATIONSPOTNAME");

                entity.Property(e => e.Signindate)
                    .HasColumnType("DATE")
                    .HasColumnName("SIGNINDATE");

                entity.Property(e => e.Signoutdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SIGNOUTDATE");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007677");

                entity.HasOne(d => d.IsolationspotnameNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Isolationspotname)
                    .HasConstraintName("SYS_C007678");
            });

            modelBuilder.Entity<DatabaseCaserecord>(entity =>
            {
                entity.ToTable("DATABASE_CASERECORD");

                entity.Property(e => e.Id)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Casetype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CASETYPE");

                entity.Property(e => e.Discoverdate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DISCOVERDATE");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Source)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DatabaseCaserecord)
                    .HasForeignKey<DatabaseCaserecord>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007671");
            });

            modelBuilder.Entity<DatabaseCourier>(entity =>
            {
                entity.ToTable("DATABASE_COURIER");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Workaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WORKADDRESS");
            });

            modelBuilder.Entity<DatabaseDemandform>(entity =>
            {
                entity.ToTable("DATABASE_DEMANDFORM");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Goodsname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GOODSNAME");

                entity.Property(e => e.Num)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("NUM");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<DatabaseDonatetounit>(entity =>
            {
                entity.HasKey(e => e.Goodsid);

                entity.ToTable("DATABASE_DONATETOUNIT");

                entity.Property(e => e.Goodsid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOODSID")
                    .IsFixedLength(true);

                entity.Property(e => e.Donatetime)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DONATETIME")
                    .IsFixedLength(true);

                entity.Property(e => e.Donorid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DONORID")
                    .IsFixedLength(true);

                entity.Property(e => e.Epidemiccontrolunitsid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EPIDEMICCONTROLUNITSID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Donor)
                    .WithMany(p => p.DatabaseDonatetounits)
                    .HasForeignKey(d => d.Donorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007672");

                entity.HasOne(d => d.Epidemiccontrolunits)
                    .WithMany(p => p.DatabaseDonatetounits)
                    .HasForeignKey(d => d.Epidemiccontrolunitsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007673");

                entity.HasOne(d => d.Goods)
                    .WithOne(p => p.DatabaseDonatetounit)
                    .HasForeignKey<DatabaseDonatetounit>(d => d.Goodsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007674");
            });

            modelBuilder.Entity<DatabaseDonor>(entity =>
            {
                entity.ToTable("DATABASE_DONOR");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<DatabaseDonorpurchase>(entity =>
            {
                entity.HasKey(e => e.Goodsid);

                entity.ToTable("DATABASE_DONORPURCHASE");

                entity.Property(e => e.Goodsid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOODSID")
                    .IsFixedLength(true);

                entity.Property(e => e.Donorid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DONORID")
                    .IsFixedLength(true);

                entity.Property(e => e.Purchasetime)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PURCHASETIME");

                entity.HasOne(d => d.Donor)
                    .WithMany(p => p.DatabaseDonorpurchases)
                    .HasForeignKey(d => d.Donorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("F_DONOR");

                entity.HasOne(d => d.Goods)
                    .WithOne(p => p.DatabaseDonorpurchase)
                    .HasForeignKey<DatabaseDonorpurchase>(d => d.Goodsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007675");
            });

            modelBuilder.Entity<DatabaseEpidemiccontrolunit>(entity =>
            {
                entity.ToTable("DATABASE_EPIDEMICCONTROLUNITS");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Citybelongs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CITYBELONGS");

                entity.Property(e => e.Districtbelongs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DISTRICTBELONGS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Servicehotline)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SERVICEHOTLINE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DatabaseGood>(entity =>
            {
                entity.ToTable("DATABASE_GOODS");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Dop)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DOP");

                entity.Property(e => e.Exp)
                    .HasPrecision(6)
                    .HasColumnName("EXP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Num)
                    .HasColumnType("NUMBER(32)")
                    .HasColumnName("NUM");

                entity.Property(e => e.Price)
                    .HasPrecision(6)
                    .HasColumnName("PRICE");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<DatabaseIsolatedpoint>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("SYS_C007636");

                entity.ToTable("DATABASE_ISOLATEDPOINTS");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Capacity)
                    .HasPrecision(10)
                    .HasColumnName("CAPACITY");

                entity.Property(e => e.Cost)
                    .HasPrecision(10)
                    .HasColumnName("COST");

                entity.Property(e => e.Num)
                    .HasPrecision(10)
                    .HasColumnName("NUM");

                entity.Property(e => e.Reigon)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REIGON");

                entity.Property(e => e.Resourcetype)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RESOURCETYPE");
            });

            modelBuilder.Entity<DatabaseIsolationassign>(entity =>
            {
                entity.ToTable("DATABASE_ISOLATIONASSIGN");

                entity.Property(e => e.Id)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Isolationspotname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISOLATIONSPOTNAME");

                entity.Property(e => e.Signindate)
                    .HasColumnType("DATE")
                    .HasColumnName("SIGNINDATE");

                entity.Property(e => e.Signoutdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SIGNOUTDATE");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DatabaseIsolationassign)
                    .HasForeignKey<DatabaseIsolationassign>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ISOPERSONID");

                entity.HasOne(d => d.IsolationspotnameNavigation)
                    .WithMany(p => p.DatabaseIsolationassigns)
                    .HasForeignKey(d => d.Isolationspotname)
                    .HasConstraintName("POINTNAME");
            });

            modelBuilder.Entity<DatabaseManage>(entity =>
            {
                entity.HasKey(e => new { e.Epidemiccontrolunitsid, e.Personid });

                entity.ToTable("DATABASE_MANAGE");

                entity.Property(e => e.Epidemiccontrolunitsid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EPIDEMICCONTROLUNITSID")
                    .IsFixedLength(true);

                entity.Property(e => e.Personid)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("PERSONID")
                    .IsFixedLength(true);

                entity.Property(e => e.Epname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPNAME");

                entity.Property(e => e.Personname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PERSONNAME");

                entity.HasOne(d => d.Epidemiccontrolunits)
                    .WithMany(p => p.DatabaseManages)
                    .HasForeignKey(d => d.Epidemiccontrolunitsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007679");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.DatabaseManages)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007680");
            });

            modelBuilder.Entity<DatabaseMedicalresource>(entity =>
            {
                entity.HasKey(e => e.Medicalresourcetype);

                entity.ToTable("DATABASE_MEDICALRESOURCE");

                entity.Property(e => e.Medicalresourcetype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MEDICALRESOURCETYPE");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AREA");

                entity.Property(e => e.Medicalresourcenumber)
                    .HasPrecision(10)
                    .HasColumnName("MEDICALRESOURCENUMBER");

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.DatabaseMedicalresources)
                    .HasForeignKey(d => d.Area)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AREA");
            });

            modelBuilder.Entity<DatabasePerson>(entity =>
            {
                entity.ToTable("DATABASE_PERSON");

                entity.Property(e => e.Id)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Age)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AGE")
                    .IsFixedLength(true);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER")
                    .IsFixedLength(true);

                entity.HasOne(d => d.AddressNavigation)
                    .WithMany(p => p.DatabasePeople)
                    .HasForeignKey(d => d.Address)
                    .HasConstraintName("ADDRESS");
            });

            modelBuilder.Entity<DatabaseRiskingarea>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("SYS_C007560");

                entity.ToTable("DATABASE_RISKINGAREA");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Riskinglevel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RISKINGLEVEL");
            });

            modelBuilder.Entity<DatabaseSampling>(entity =>
            {
                entity.ToTable("DATABASE_SAMPLING");

                entity.Property(e => e.Id)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Detectiontime)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DETECTIONTIME")
                    .IsFixedLength(true);

                entity.Property(e => e.Gender)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GENDER");

                entity.Property(e => e.Idcard)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDCARD");

                entity.Property(e => e.Institutionname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INSTITUTIONNAME");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Place)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PLACE");

                entity.Property(e => e.Testresult)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TESTRESULT");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DatabaseSampling)
                    .HasForeignKey<DatabaseSampling>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007683");

                entity.HasOne(d => d.InstitutionnameNavigation)
                    .WithMany(p => p.DatabaseSamplings)
                    .HasForeignKey(d => d.Institutionname)
                    .HasConstraintName("INSTITUTIONNAE");
            });

            modelBuilder.Entity<DatabaseStaff>(entity =>
            {
                entity.ToTable("DATABASE_STAFF");

                entity.Property(e => e.Id)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.RiskGarde)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RISK_GARDE");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STREET");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DatabaseStaff)
                    .HasForeignKey<DatabaseStaff>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007685");
            });

            modelBuilder.Entity<DatabaseTestinfo>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Testinsname })
                    .HasName("TABLE1_PK");

                entity.ToTable("DATABASE_TESTINFO");

                entity.Property(e => e.Id)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Testinsname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TESTINSNAME");

                entity.Property(e => e.Samtime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SAMTIME");

                entity.Property(e => e.Testtime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TESTTIME");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.DatabaseTestinfos)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TESTINFO1");

                entity.HasOne(d => d.TestinsnameNavigation)
                    .WithMany(p => p.DatabaseTestinfos)
                    .HasForeignKey(d => d.Testinsname)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TESTINFO2");
            });

            modelBuilder.Entity<DatabaseTestingcenter>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("SYS_C007556");

                entity.ToTable("DATABASE_TESTINGCENTER");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Maxnum)
                    .HasPrecision(8)
                    .HasColumnName("MAXNUM");

                entity.Property(e => e.Resourcetype)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RESOURCETYPE");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.DatabaseTestingcenters)
                    .HasForeignKey(d => d.Location)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LOCATION");
            });

            modelBuilder.Entity<DatabaseTestingcenterassignment>(entity =>
            {
                entity.ToTable("DATABASE_TESTINGCENTERASSIGNMENT");

                entity.Property(e => e.Id)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Testingdate)
                    .HasColumnType("DATE")
                    .HasColumnName("TESTINGDATE");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DatabaseTestingcenterassignment)
                    .HasForeignKey<DatabaseTestingcenterassignment>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID");

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.DatabaseTestingcenterassignments)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NAME");
            });

            modelBuilder.Entity<DatabaseTestinginstitution>(entity =>
            {
                entity.HasKey(e => e.Institutionname);

                entity.ToTable("DATABASE_TESTINGINSTITUTION");

                entity.Property(e => e.Institutionname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INSTITUTIONNAME");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DISTRICT");

                entity.Property(e => e.Maxnumber)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("MAXNUMBER");

                entity.Property(e => e.Resourcetype)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RESOURCETYPE");

                entity.HasOne(d => d.DistrictNavigation)
                    .WithMany(p => p.DatabaseTestinginstitutions)
                    .HasForeignKey(d => d.District)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DISTRICT");
            });

            modelBuilder.Entity<DatabaseTrajectory>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Time, e.Spot });

                entity.ToTable("DATABASE_TRAJECTORY");

                entity.Property(e => e.Id)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Time)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TIME")
                    .IsFixedLength(true);

                entity.Property(e => e.Spot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPOT");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.DatabaseTrajectories)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007691");

                entity.HasOne(d => d.SpotNavigation)
                    .WithMany(p => p.DatabaseTrajectories)
                    .HasForeignKey(d => d.Spot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SPOT");
            });

            modelBuilder.Entity<DatabaseTransport>(entity =>
            {
                entity.HasKey(e => e.Goodsid)
                    .HasName("SYS_C007608");

                entity.ToTable("DATABASE_TRANSPORT");

                entity.Property(e => e.Goodsid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOODSID")
                    .IsFixedLength(true);

                entity.Property(e => e.Courierid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COURIERID")
                    .IsFixedLength(true);

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESTINATION");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Startaddress)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STARTADDRESS");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STATE");

                entity.HasOne(d => d.Courier)
                    .WithMany(p => p.DatabaseTransports)
                    .HasForeignKey(d => d.Courierid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007692");

                entity.HasOne(d => d.Goods)
                    .WithOne(p => p.DatabaseTransport)
                    .HasForeignKey<DatabaseTransport>(d => d.Goodsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007693");
            });

            modelBuilder.Entity<DatabaseUnitspurchase>(entity =>
            {
                entity.HasKey(e => new { e.Goodsid, e.Epidemiccontrolunitsid });

                entity.ToTable("DATABASE_UNITSPURCHASE");

                entity.Property(e => e.Goodsid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOODSID")
                    .IsFixedLength(true);

                entity.Property(e => e.Epidemiccontrolunitsid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EPIDEMICCONTROLUNITSID")
                    .IsFixedLength(true);

                entity.Property(e => e.Purchasetime)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PURCHASETIME");

              

                entity.HasOne(d => d.Goods)
                    .WithOne(p => p.DatabaseUnitspurchase)
                    .HasForeignKey<DatabaseUnitspurchase>(d => d.Goodsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007695");
            });

            modelBuilder.Entity<DatabaseUser>(entity =>
            {
                entity.ToTable("DATABASE_USERS");

                entity.Property(e => e.Id)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Loginstatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOGINSTATUS");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DatabaseUser)
                    .HasForeignKey<DatabaseUser>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PERSONID");
            });

            modelBuilder.Entity<DatabaseViewdemandform>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DATABASE_VIEWDEMANDFORM");

                entity.Property(e => e.Demandformid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEMANDFORMID")
                    .IsFixedLength(true);

                entity.Property(e => e.Epidemiccontrolunitsid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EPIDEMICCONTROLUNITSID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Demandform)
                    .WithMany()
                    .HasForeignKey(d => d.Demandformid)
                    .HasConstraintName("DATABASE_VIEWDEMANDFORM_D_FK1");

                entity.HasOne(d => d.Epidemiccontrolunits)
                    .WithMany()
                    .HasForeignKey(d => d.Epidemiccontrolunitsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DATABASE_VIEWDEMANDFORM_D_FK2");
            });

            modelBuilder.Entity<DatabaseVolunteer>(entity =>
            {
                entity.ToTable("DATABASE_VOLUNTEER");

                entity.HasIndex(e => new { e.Location, e.Servedate, e.Origin, e.Volunteertype }, "PK_DATABASE_VOLUNTEER")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ORIGIN");

                entity.Property(e => e.Servedate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SERVEDATE");

                entity.Property(e => e.Volunteertype)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VOLUNTEERTYPE");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DatabaseVolunteer)
                    .HasForeignKey<DatabaseVolunteer>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007699");
            });

            modelBuilder.Entity<DatabaseWritedemandform>(entity =>
            {
                entity.HasKey(e => new { e.Personid, e.Demandformid })
                    .HasName("DATABASE_WRITEDEMANDFORM_PK");

                entity.ToTable("DATABASE_WRITEDEMANDFORM");

                entity.Property(e => e.Personid)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("PERSONID")
                    .IsFixedLength(true);

                entity.Property(e => e.Demandformid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEMANDFORMID")
                    .IsFixedLength(true);

                entity.Property(e => e.Writetime)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRITETIME");

                entity.HasOne(d => d.Demandform)
                    .WithMany(p => p.DatabaseWritedemandforms)
                    .HasForeignKey(d => d.Demandformid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007689");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.DatabaseWritedemandforms)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C007700");
            });

            modelBuilder.Entity<Help>(entity =>
            {
                entity.HasKey(e => new { e.Topic, e.Seq })
                    .HasName("HELP_TOPIC_SEQ");

                entity.ToTable("HELP");

                entity.Property(e => e.Topic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOPIC");

                entity.Property(e => e.Seq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ");

                entity.Property(e => e.Info)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("INFO");
            });

            modelBuilder.Entity<LogmnrAgeSpill>(entity =>
            {
                entity.HasKey(e => new { e.Session, e.Pdbid, e.Xidusn, e.Xidslt, e.Xidsqn, e.Chunk, e.Sequence })
                    .HasName("LOGMNR_AGE_SPILL$_PK");

                entity.ToTable("LOGMNR_AGE_SPILL$");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Pdbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDBID");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.Chunk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHUNK");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE#");

                entity.Property(e => e.Offset)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OFFSET");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.SpillData)
                    .HasColumnType("BLOB")
                    .HasColumnName("SPILL_DATA");
            });

            modelBuilder.Entity<LogmnrAttrcol>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol })
                    .HasName("LOGMNR_ATTRCOL$_PK");

                entity.ToTable("LOGMNR_ATTRCOL$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol }, "LOGMNR_I1ATTRCOL$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<LogmnrAttribute>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Toid, e.Version, e.Attribute })
                    .HasName("LOGMNR_ATTRIBUTE$_PK");

                entity.ToTable("LOGMNR_ATTRIBUTE$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Toid, e.Version, e.Attribute }, "LOGMNR_I1ATTRIBUTE$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Toid).HasColumnName("TOID");

                entity.Property(e => e.Version)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VERSION#");

                entity.Property(e => e.Attribute)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTRIBUTE#");

                entity.Property(e => e.AttrToid).HasColumnName("ATTR_TOID");

                entity.Property(e => e.AttrVersion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTR_VERSION#");

                entity.Property(e => e.Charsetform)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHARSETFORM");

                entity.Property(e => e.Charsetid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHARSETID");

                entity.Property(e => e.Externname)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNNAME");

                entity.Property(e => e.Getter)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GETTER");

                entity.Property(e => e.Length)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LENGTH");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Name)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Precision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRECISION#");

                entity.Property(e => e.Properties)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTIES");

                entity.Property(e => e.Scale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCALE");

                entity.Property(e => e.Setter)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SETTER");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE5");

                entity.Property(e => e.Synobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SYNOBJ#");

                entity.Property(e => e.Xflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XFLAGS");
            });

            modelBuilder.Entity<LogmnrCcol>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Con, e.Intcol })
                    .HasName("LOGMNR_CCOL$_PK");

                entity.ToTable("LOGMNR_CCOL$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Con, e.Intcol }, "LOGMNR_I1CCOL$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Con)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CON#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Col)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COL#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Pos)
                    .HasColumnType("NUMBER")
                    .HasColumnName("POS#");
            });

            modelBuilder.Entity<LogmnrCdef>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Con })
                    .HasName("LOGMNR_CDEF$_PK");

                entity.ToTable("LOGMNR_CDEF$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Con }, "LOGMNR_I1CDEF$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Robj }, "LOGMNR_I2CDEF$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj }, "LOGMNR_I3CDEF$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Con)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CON#");

                entity.Property(e => e.Cols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLS");

                entity.Property(e => e.Defer)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFER");

                entity.Property(e => e.Enabled)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENABLED");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Rcon)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RCON#");

                entity.Property(e => e.Robj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROBJ#");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPE#");
            });

            modelBuilder.Entity<LogmnrCol>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol })
                    .HasName("LOGMNR_COL$_PK");

                entity.ToTable("LOGMNR_COL$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol }, "LOGMNR_I1COL$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Name }, "LOGMNR_I2COL$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Col }, "LOGMNR_I3COL$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Acdrrescol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRRESCOL#");

                entity.Property(e => e.Charsetform)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("CHARSETFORM");

                entity.Property(e => e.Charsetid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("CHARSETID");

                entity.Property(e => e.Col)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("COL#");

                entity.Property(e => e.Collid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLLID");

                entity.Property(e => e.Collintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLLINTCOL#");

                entity.Property(e => e.Length)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LENGTH");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Name)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Null)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("NULL$");

                entity.Property(e => e.Precision)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("PRECISION#");

                entity.Property(e => e.Property)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("PROPERTY");

                entity.Property(e => e.Scale)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("SCALE");

                entity.Property(e => e.Segcol)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("SEGCOL#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("TYPE#");
            });

            modelBuilder.Entity<LogmnrColtype>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol })
                    .HasName("LOGMNR_COLTYPE$_PK");

                entity.ToTable("LOGMNR_COLTYPE$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol }, "LOGMNR_I1COLTYPE$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Col)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COL#");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.IntcolS1).HasColumnName("INTCOL#S");

                entity.Property(e => e.Intcols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOLS");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Packed)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PACKED");

                entity.Property(e => e.Synobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SYNOBJ#");

                entity.Property(e => e.Toid).HasColumnName("TOID");

                entity.Property(e => e.Typidcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPIDCOL#");

                entity.Property(e => e.Version)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VERSION#");
            });

            modelBuilder.Entity<LogmnrCon>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Con })
                    .HasName("LOGMNR_CON$_PK");

                entity.ToTable("LOGMNR_CON$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Con }, "LOGMNR_I1CON$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Con)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CON#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Owner)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OWNER#");

                entity.Property(e => e.StartScnbas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCNBAS");

                entity.Property(e => e.StartScnwrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCNWRP");
            });

            modelBuilder.Entity<LogmnrContainer>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj })
                    .HasName("LOGMNR_CONTAINER$_PK");

                entity.ToTable("LOGMNR_CONTAINER$");

                entity.HasIndex(e => new { e.LogmnrUid, e.ConId }, "LOGMNR_I1CONTAINER$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.ConId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CON_ID#");

                entity.Property(e => e.ConUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CON_UID");

                entity.Property(e => e.CreateScnbas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATE_SCNBAS");

                entity.Property(e => e.CreateScnwrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATE_SCNWRP");

                entity.Property(e => e.Dbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DBID");

                entity.Property(e => e.FedRootConId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FED_ROOT_CON_ID#");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Vsn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VSN");
            });

            modelBuilder.Entity<LogmnrDictionary>(entity =>
            {
                entity.HasKey(e => e.LogmnrUid)
                    .HasName("LOGMNR_DICTIONARY$_PK");

                entity.ToTable("LOGMNR_DICTIONARY$");

                entity.HasIndex(e => e.LogmnrUid, "LOGMNR_I1DICTIONARY$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.DbCharacterSet)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("DB_CHARACTER_SET");

                entity.Property(e => e.DbCreated)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DB_CREATED");

                entity.Property(e => e.DbDictCreated)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DB_DICT_CREATED");

                entity.Property(e => e.DbDictMaxobjects)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("DB_DICT_MAXOBJECTS");

                entity.Property(e => e.DbDictObjectcount)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("DB_DICT_OBJECTCOUNT");

                entity.Property(e => e.DbDictScn)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("DB_DICT_SCN");

                entity.Property(e => e.DbGlobalName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("DB_GLOBAL_NAME");

                entity.Property(e => e.DbId)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("DB_ID");

                entity.Property(e => e.DbName)
                    .HasMaxLength(27)
                    .IsUnicode(false)
                    .HasColumnName("DB_NAME");

                entity.Property(e => e.DbRedoRelease)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DB_REDO_RELEASE");

                entity.Property(e => e.DbRedoTypeId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DB_REDO_TYPE_ID");

                entity.Property(e => e.DbResetlogsChange)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("DB_RESETLOGS_CHANGE#");

                entity.Property(e => e.DbResetlogsTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DB_RESETLOGS_TIME");

                entity.Property(e => e.DbStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DB_STATUS");

                entity.Property(e => e.DbThreadMap)
                    .HasMaxLength(8)
                    .HasColumnName("DB_THREAD_MAP");

                entity.Property(e => e.DbTxnScnbas)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("DB_TXN_SCNBAS");

                entity.Property(e => e.DbTxnScnwrp)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("DB_TXN_SCNWRP");

                entity.Property(e => e.DbVersion)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DB_VERSION");

                entity.Property(e => e.DbVersionTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DB_VERSION_TIME");

                entity.Property(e => e.FedRootConId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FED_ROOT_CON_ID#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.PdbCount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDB_COUNT");

                entity.Property(e => e.PdbCreateScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDB_CREATE_SCN");

                entity.Property(e => e.PdbDbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDB_DBID");

                entity.Property(e => e.PdbGlobalName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PDB_GLOBAL_NAME");

                entity.Property(e => e.PdbGuid).HasColumnName("PDB_GUID");

                entity.Property(e => e.PdbId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDB_ID");

                entity.Property(e => e.PdbName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PDB_NAME");

                entity.Property(e => e.PdbUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDB_UID");
            });

            modelBuilder.Entity<LogmnrDictstate>(entity =>
            {
                entity.HasKey(e => e.LogmnrUid)
                    .HasName("LOGMNR_DICTSTATE$_PK");

                entity.ToTable("LOGMNR_DICTSTATE$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.EndScnbas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("END_SCNBAS");

                entity.Property(e => e.EndScnwrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("END_SCNWRP");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Rbablk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RBABLK");

                entity.Property(e => e.Rbabyte)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RBABYTE");

                entity.Property(e => e.Rbasqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RBASQN");

                entity.Property(e => e.RedoThread)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REDO_THREAD");

                entity.Property(e => e.StartScnbas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCNBAS");

                entity.Property(e => e.StartScnwrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCNWRP");
            });

            modelBuilder.Entity<LogmnrDid>(entity =>
            {
                entity.HasKey(e => e.Session)
                    .HasName("LOGMNR_DID$_PK");

                entity.ToTable("LOGMNR_DID$");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LogmnrDid1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_DID");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasPrecision(6)
                    .HasColumnName("SPARE4");
            });

            modelBuilder.Entity<LogmnrEnc>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Owner })
                    .HasName("LOGMNR_ENC$_PK");

                entity.ToTable("LOGMNR_ENC$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Owner }, "LOGMNR_I1ENC$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Owner)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OWNER#");

                entity.Property(e => e.Colklc).HasColumnName("COLKLC");

                entity.Property(e => e.Encalg)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENCALG");

                entity.Property(e => e.Flag)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAG");

                entity.Property(e => e.Intalg)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTALG");

                entity.Property(e => e.Klclen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KLCLEN");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Mkeyid)
                    .IsRequired()
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("MKEYID");
            });

            modelBuilder.Entity<LogmnrError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGMNR_ERROR$");

                entity.Property(e => e.Code)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CODE");

                entity.Property(e => e.Message)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .IsUnicode(false)
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .IsUnicode(false)
                    .HasColumnName("SPARE5");

                entity.Property(e => e.TimeOfError)
                    .HasColumnType("DATE")
                    .HasColumnName("TIME_OF_ERROR");
            });

            modelBuilder.Entity<LogmnrFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGMNR_FILTER$");

                entity.Property(e => e.Attr1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTR1");

                entity.Property(e => e.Attr10)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ATTR10");

                entity.Property(e => e.Attr11)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ATTR11");

                entity.Property(e => e.Attr2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTR2");

                entity.Property(e => e.Attr3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTR3");

                entity.Property(e => e.Attr4)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTR4");

                entity.Property(e => e.Attr5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTR5");

                entity.Property(e => e.Attr6)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTR6");

                entity.Property(e => e.Attr7)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ATTR7");

                entity.Property(e => e.Attr8)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ATTR8");

                entity.Property(e => e.Attr9)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ATTR9");

                entity.Property(e => e.FilterScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FILTER_SCN");

                entity.Property(e => e.FilterType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_TYPE");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("DATE")
                    .HasColumnName("SPARE3");
            });

            modelBuilder.Entity<LogmnrGlobal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGMNR_GLOBAL$");

                entity.Property(e => e.HighRecidDeleted)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HIGH_RECID_DELETED");

                entity.Property(e => e.HighRecidForeign)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HIGH_RECID_FOREIGN");

                entity.Property(e => e.LocalResetScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOCAL_RESET_SCN");

                entity.Property(e => e.LocalResetTimestamp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOCAL_RESET_TIMESTAMP");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .HasColumnType("DATE")
                    .HasColumnName("SPARE5");

                entity.Property(e => e.VersionTimestamp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VERSION_TIMESTAMP");
            });

            modelBuilder.Entity<LogmnrGtTabInclude>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGMNR_GT_TAB_INCLUDE$");

                entity.Property(e => e.PdbName)
                    .HasMaxLength(390)
                    .IsUnicode(false)
                    .HasColumnName("PDB_NAME");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(390)
                    .IsUnicode(false)
                    .HasColumnName("SCHEMA_NAME");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.TableName)
                    .HasMaxLength(390)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");
            });

            modelBuilder.Entity<LogmnrGtUserInclude>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGMNR_GT_USER_INCLUDE$");

                entity.Property(e => e.PdbName)
                    .HasMaxLength(390)
                    .IsUnicode(false)
                    .HasColumnName("PDB_NAME");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.UserName)
                    .HasMaxLength(390)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.Property(e => e.UserType)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USER_TYPE");
            });

            modelBuilder.Entity<LogmnrGtXidInclude>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGMNR_GT_XID_INCLUDE$");

                entity.Property(e => e.PdbName)
                    .HasMaxLength(390)
                    .IsUnicode(false)
                    .HasColumnName("PDB_NAME");

                entity.Property(e => e.Pdbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDBID");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");
            });

            modelBuilder.Entity<LogmnrIcol>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol })
                    .HasName("LOGMNR_ICOL$_PK");

                entity.ToTable("LOGMNR_ICOL$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol }, "LOGMNR_I1ICOL$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Bo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BO#");

                entity.Property(e => e.Col)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COL#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Pos)
                    .HasColumnType("NUMBER")
                    .HasColumnName("POS#");

                entity.Property(e => e.Segcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEGCOL#");
            });

            modelBuilder.Entity<LogmnrIdnseq>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol })
                    .HasName("LOGMNR_IDNSEQ$_PK");

                entity.ToTable("LOGMNR_IDNSEQ$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol }, "LOGMNR_I1IDNSEQ$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Seqobj }, "LOGMNR_I2IDNSEQ$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Seqobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQOBJ#");

                entity.Property(e => e.Startwith)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STARTWITH");
            });

            modelBuilder.Entity<LogmnrInd>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj })
                    .HasName("LOGMNR_IND$_PK");

                entity.ToTable("LOGMNR_IND$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj }, "LOGMNR_I1IND$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Bo }, "LOGMNR_I2IND$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Bo)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("BO#");

                entity.Property(e => e.Cols)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("COLS");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Property)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTY");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("TYPE#");
            });

            modelBuilder.Entity<LogmnrIndcompart>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj })
                    .HasName("LOGMNR_INDCOMPART$_PK");

                entity.ToTable("LOGMNR_INDCOMPART$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj }, "LOGMNR_I1INDCOMPART$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Bo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BO#");

                entity.Property(e => e.Dataobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DATAOBJ#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Part)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PART#");
            });

            modelBuilder.Entity<LogmnrIndpart>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Bo })
                    .HasName("LOGMNR_INDPART$_PK");

                entity.ToTable("LOGMNR_INDPART$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Bo }, "LOGMNR_I1INDPART$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Bo }, "LOGMNR_I2INDPART$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Bo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BO#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Part)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PART#");

                entity.Property(e => e.Ts)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TS#");
            });

            modelBuilder.Entity<LogmnrIndsubpart>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Pobj })
                    .HasName("LOGMNR_INDSUBPART$_PK");

                entity.ToTable("LOGMNR_INDSUBPART$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Pobj }, "LOGMNR_I1INDSUBPART$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Pobj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("POBJ#");

                entity.Property(e => e.Dataobj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("DATAOBJ#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Subpart)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("SUBPART#");

                entity.Property(e => e.Ts)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("TS#");
            });

            modelBuilder.Entity<LogmnrKopm>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Name })
                    .HasName("LOGMNR_KOPM$_PK");

                entity.ToTable("LOGMNR_KOPM$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Name }, "LOGMNR_I1KOPM$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Name)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Length)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LENGTH");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Metadata)
                    .HasMaxLength(255)
                    .HasColumnName("METADATA");
            });

            modelBuilder.Entity<LogmnrLob>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol })
                    .HasName("LOGMNR_LOB$_PK");

                entity.ToTable("LOGMNR_LOB$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol }, "LOGMNR_I1LOB$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Chunk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHUNK");

                entity.Property(e => e.Col)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COL#");

                entity.Property(e => e.Lobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOBJ#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");
            });

            modelBuilder.Entity<LogmnrLobfrag>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Fragobj })
                    .HasName("LOGMNR_LOBFRAG$_PK");

                entity.ToTable("LOGMNR_LOBFRAG$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Fragobj }, "LOGMNR_I1LOBFRAG$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Fragobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FRAGOBJ#");

                entity.Property(e => e.Frag)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FRAG#");

                entity.Property(e => e.Indfragobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INDFRAGOBJ#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Parentobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARENTOBJ#");

                entity.Property(e => e.Tabfragobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TABFRAGOBJ#");
            });

            modelBuilder.Entity<LogmnrLog>(entity =>
            {
                entity.HasKey(e => new { e.Session, e.Thread, e.Sequence, e.FirstChange, e.DbId, e.ResetlogsChange, e.ResetTimestamp })
                    .HasName("LOGMNR_LOG$_PK");

                entity.ToTable("LOGMNR_LOG$");

                entity.HasIndex(e => e.FirstChange, "LOGMNR_LOG$_FIRST_CHANGE#");

                entity.HasIndex(e => e.Flags, "LOGMNR_LOG$_FLAGS");

                entity.HasIndex(e => new { e.FileName, e.Status }, "LOGMNR_LOG$_PURGE_IDX1");

                entity.HasIndex(e => new { e.Session, e.ResetTimestamp, e.NextChange, e.Status }, "LOGMNR_LOG$_PURGE_IDX2");

                entity.HasIndex(e => e.Recid, "LOGMNR_LOG$_RECID");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Thread)
                    .HasColumnType("NUMBER")
                    .HasColumnName("THREAD#");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE#");

                entity.Property(e => e.FirstChange)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FIRST_CHANGE#");

                entity.Property(e => e.DbId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DB_ID");

                entity.Property(e => e.ResetlogsChange)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESETLOGS_CHANGE#");

                entity.Property(e => e.ResetTimestamp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESET_TIMESTAMP");

                entity.Property(e => e.BlockSize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BLOCK_SIZE");

                entity.Property(e => e.Blocks)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BLOCKS");

                entity.Property(e => e.Contents)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONTENTS");

                entity.Property(e => e.DictBegin)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DICT_BEGIN");

                entity.Property(e => e.DictEnd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DICT_END");

                entity.Property(e => e.FileName)
                    .HasMaxLength(513)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME");

                entity.Property(e => e.FirstTime)
                    .HasColumnType("DATE")
                    .HasColumnName("FIRST_TIME");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Info)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("INFO");

                entity.Property(e => e.MarkDeleteTimestamp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MARK_DELETE_TIMESTAMP");

                entity.Property(e => e.NextChange)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NEXT_CHANGE#");

                entity.Property(e => e.NextTime)
                    .HasColumnType("DATE")
                    .HasColumnName("NEXT_TIME");

                entity.Property(e => e.PrevResetTimestamp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PREV_RESET_TIMESTAMP");

                entity.Property(e => e.PrevResetlogsChange)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PREV_RESETLOGS_CHANGE#");

                entity.Property(e => e.Recid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RECID");

                entity.Property(e => e.Recstamp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RECSTAMP");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE5");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");

                entity.Property(e => e.StatusInfo)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_INFO");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("DATE")
                    .HasColumnName("TIMESTAMP");
            });

            modelBuilder.Entity<LogmnrLogmnrBuildlog>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.InitialXid })
                    .HasName("LOGMNR_LOGMNR_BUILDLOG_PK");

                entity.ToTable("LOGMNR_LOGMNR_BUILDLOG");

                entity.HasIndex(e => new { e.LogmnrUid, e.InitialXid }, "LOGMNR_I1LOGMNR_BUILDLOG");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.InitialXid)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("INITIAL_XID");

                entity.Property(e => e.BuildDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BUILD_DATE");

                entity.Property(e => e.CdbXid)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("CDB_XID");

                entity.Property(e => e.CompletionStatus)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMPLETION_STATUS");

                entity.Property(e => e.CurrentBuildState)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CURRENT_BUILD_STATE");

                entity.Property(e => e.DbTxnScnbas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DB_TXN_SCNBAS");

                entity.Property(e => e.DbTxnScnwrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DB_TXN_SCNWRP");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.MarkedLogFileLowScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MARKED_LOG_FILE_LOW_SCN");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .IsUnicode(false)
                    .HasColumnName("SPARE2");
            });

            modelBuilder.Entity<LogmnrNtab>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol })
                    .HasName("LOGMNR_NTAB$_PK");

                entity.ToTable("LOGMNR_NTAB$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol }, "LOGMNR_I1NTAB$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Ntab }, "LOGMNR_I2NTAB$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Col)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COL#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Ntab)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NTAB#");
            });

            modelBuilder.Entity<LogmnrObj>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj })
                    .HasName("LOGMNR_OBJ$_PK");

                entity.ToTable("LOGMNR_OBJ$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj }, "LOGMNR_I1OBJ$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Oid }, "LOGMNR_I2OBJ$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Name }, "LOGMNR_I3OBJ$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Linkname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("LINKNAME");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Name)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Namespace)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("NAMESPACE");

                entity.Property(e => e.Objv)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OBJV#");

                entity.Property(e => e.Oid).HasColumnName("OID$");

                entity.Property(e => e.Owner)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OWNER#");

                entity.Property(e => e.Remoteowner)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("REMOTEOWNER");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.StartScnbas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCNBAS");

                entity.Property(e => e.StartScnwrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCNWRP");

                entity.Property(e => e.Stime)
                    .HasColumnType("DATE")
                    .HasColumnName("STIME");

                entity.Property(e => e.Subname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SUBNAME");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("TYPE#");
            });

            modelBuilder.Entity<LogmnrOpqtype>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol })
                    .HasName("LOGMNR_OPQTYPE$_PK");

                entity.ToTable("LOGMNR_OPQTYPE$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol }, "LOGMNR_I1OPQTYPE$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Elemnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ELEMNUM");

                entity.Property(e => e.Extracol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EXTRACOL");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Lobcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOBCOL");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Objcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJCOL");

                entity.Property(e => e.Schemaoid).HasColumnName("SCHEMAOID");

                entity.Property(e => e.Schemaurl)
                    .IsUnicode(false)
                    .HasColumnName("SCHEMAURL");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<LogmnrParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGMNR_PARAMETER$");

                entity.HasIndex(e => new { e.Session, e.Name }, "LOGMNR_PARAMETER_INDX");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Scn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCN");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPE");

                entity.Property(e => e.Value)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<LogmnrPartobj>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj })
                    .HasName("LOGMNR_PARTOBJ$_PK");

                entity.ToTable("LOGMNR_PARTOBJ$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj }, "LOGMNR_I1PARTOBJ$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Defextpct)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFEXTPCT");

                entity.Property(e => e.Defextsize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFEXTSIZE");

                entity.Property(e => e.Defgroups)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFGROUPS");

                entity.Property(e => e.Definclcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFINCLCOL");

                entity.Property(e => e.Definitrans)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFINITRANS");

                entity.Property(e => e.Deflists)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFLISTS");

                entity.Property(e => e.Deflogging)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFLOGGING");

                entity.Property(e => e.Defmaxexts)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFMAXEXTS");

                entity.Property(e => e.Defmaxtrans)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFMAXTRANS");

                entity.Property(e => e.Defminexts)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFMINEXTS");

                entity.Property(e => e.Defpctfree)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFPCTFREE");

                entity.Property(e => e.Defpctthres)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFPCTTHRES");

                entity.Property(e => e.Defpctused)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFPCTUSED");

                entity.Property(e => e.Deftiniexts)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFTINIEXTS");

                entity.Property(e => e.Defts)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFTS#");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Parameters)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETERS");

                entity.Property(e => e.Partcnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARTCNT");

                entity.Property(e => e.Partkeycols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARTKEYCOLS");

                entity.Property(e => e.Parttype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARTTYPE");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");
            });

            modelBuilder.Entity<LogmnrPdbInfo>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrDid, e.LogmnrMdh, e.PluginScn })
                    .HasName("LOGMNR_PDB_INFO$_PK");

                entity.ToTable("LOGMNR_PDB_INFO$");

                entity.Property(e => e.LogmnrDid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_DID");

                entity.Property(e => e.LogmnrMdh)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_MDH");

                entity.Property(e => e.PluginScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PLUGIN_SCN");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.PdbGlobalName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PDB_GLOBAL_NAME");

                entity.Property(e => e.PdbId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDB_ID");

                entity.Property(e => e.PdbName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PDB_NAME");

                entity.Property(e => e.PdbUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDB_UID");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasPrecision(6)
                    .HasColumnName("SPARE4");

                entity.Property(e => e.UnplugScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UNPLUG_SCN");
            });

            modelBuilder.Entity<LogmnrProcessedLog>(entity =>
            {
                entity.HasKey(e => new { e.Session, e.Thread })
                    .HasName("LOGMNR_PROCESSED_LOG$_PK");

                entity.ToTable("LOGMNR_PROCESSED_LOG$");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Thread)
                    .HasColumnType("NUMBER")
                    .HasColumnName("THREAD#");

                entity.Property(e => e.FileName)
                    .HasMaxLength(513)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME");

                entity.Property(e => e.FirstChange)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FIRST_CHANGE#");

                entity.Property(e => e.FirstTime)
                    .HasColumnType("DATE")
                    .HasColumnName("FIRST_TIME");

                entity.Property(e => e.Info)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("INFO");

                entity.Property(e => e.NextChange)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NEXT_CHANGE#");

                entity.Property(e => e.NextTime)
                    .HasColumnType("DATE")
                    .HasColumnName("NEXT_TIME");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE#");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("DATE")
                    .HasColumnName("TIMESTAMP");
            });

            modelBuilder.Entity<LogmnrProfilePlsqlStat>(entity =>
            {
                entity.HasKey(e => new { e.Pkgowner, e.Pkgname, e.Name })
                    .HasName("LOGMNR_PROFILE_PLSQL$_PK");

                entity.ToTable("LOGMNR_PROFILE_PLSQL_STATS$");

                entity.Property(e => e.Pkgowner)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PKGOWNER");

                entity.Property(e => e.Pkgname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PKGNAME");

                entity.Property(e => e.Name)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NAME");

                entity.Property(e => e.Oggunsuppopnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OGGUNSUPPOPNUM");

                entity.Property(e => e.Opnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OPNUM");

                entity.Property(e => e.Pragmaop)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRAGMAOP");

                entity.Property(e => e.Redorate)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REDORATE");

                entity.Property(e => e.Redosize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REDOSIZE");

                entity.Property(e => e.Spare1)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE5");

                entity.Property(e => e.Spare6)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE6");

                entity.Property(e => e.Tlsbyunsuppopnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TLSBYUNSUPPOPNUM");
            });

            modelBuilder.Entity<LogmnrProfileTableStat>(entity =>
            {
                entity.HasKey(e => e.Objid)
                    .HasName("LOGMNR_PROFILE_TABLE$_PK");

                entity.ToTable("LOGMNR_PROFILE_TABLE_STATS$");

                entity.Property(e => e.Objid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJID");

                entity.Property(e => e.Ddlnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DDLNUM");

                entity.Property(e => e.Deletenum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELETENUM");

                entity.Property(e => e.Insertnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INSERTNUM");

                entity.Property(e => e.Maxlobsize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MAXLOBSIZE");

                entity.Property(e => e.Name)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Oggfetchopnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OGGFETCHOPNUM");

                entity.Property(e => e.Oggplsqlopnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OGGPLSQLOPNUM");

                entity.Property(e => e.Oggunsuppopnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OGGUNSUPPOPNUM");

                entity.Property(e => e.Opnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OPNUM");

                entity.Property(e => e.Owner)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Partitionattr)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARTITIONATTR");

                entity.Property(e => e.Partnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARTNUM");

                entity.Property(e => e.Property1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTY1");

                entity.Property(e => e.Property2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTY2");

                entity.Property(e => e.Redorate)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REDORATE");

                entity.Property(e => e.Redosize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REDOSIZE");

                entity.Property(e => e.Spare1)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE5");

                entity.Property(e => e.Spare6)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE6");

                entity.Property(e => e.Tlsbyunsuppopnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TLSBYUNSUPPOPNUM");

                entity.Property(e => e.Updatenum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UPDATENUM");
            });

            modelBuilder.Entity<LogmnrProp>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Name })
                    .HasName("LOGMNR_PROPS$_PK");

                entity.ToTable("LOGMNR_PROPS$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Name }, "LOGMNR_I1PROPS$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Name)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Comment)
                    .IsUnicode(false)
                    .HasColumnName("COMMENT$");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Value)
                    .IsUnicode(false)
                    .HasColumnName("VALUE$");
            });

            modelBuilder.Entity<LogmnrRefcon>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol })
                    .HasName("LOGMNR_REFCON$_PK");

                entity.ToTable("LOGMNR_REFCON$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol }, "LOGMNR_I1REFCON$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Col)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COL#");

                entity.Property(e => e.Expctoid).HasColumnName("EXPCTOID");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Reftyp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REFTYP");

                entity.Property(e => e.Stabid).HasColumnName("STABID");
            });

            modelBuilder.Entity<LogmnrRestartCkpt>(entity =>
            {
                entity.HasKey(e => new { e.Session, e.CkptScn, e.Xidusn, e.Xidslt, e.Xidsqn, e.Pdbid, e.SessionNum, e.SerialNum })
                    .HasName("LOGMNR_RESTART_CKPT$_PK");

                entity.ToTable("LOGMNR_RESTART_CKPT$");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.CkptScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CKPT_SCN");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.Pdbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDBID");

                entity.Property(e => e.SessionNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION_NUM");

                entity.Property(e => e.SerialNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SERIAL_NUM");

                entity.Property(e => e.CkptInfo)
                    .HasColumnType("BLOB")
                    .HasColumnName("CKPT_INFO");

                entity.Property(e => e.ClientData)
                    .HasColumnType("BLOB")
                    .HasColumnName("CLIENT_DATA");

                entity.Property(e => e.Flag)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAG");

                entity.Property(e => e.Offset)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OFFSET");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Valid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VALID");
            });

            modelBuilder.Entity<LogmnrRestartCkptTxinfo>(entity =>
            {
                entity.HasKey(e => new { e.Session, e.Xidusn, e.Xidslt, e.Xidsqn, e.SessionNum, e.SerialNum, e.EffectiveScn })
                    .HasName("LOGMNR_RESTART_CKPT_TXINFO$_PK");

                entity.ToTable("LOGMNR_RESTART_CKPT_TXINFO$");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.SessionNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION_NUM");

                entity.Property(e => e.SerialNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SERIAL_NUM");

                entity.Property(e => e.EffectiveScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EFFECTIVE_SCN");

                entity.Property(e => e.Flag)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAG");

                entity.Property(e => e.Offset)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OFFSET");

                entity.Property(e => e.StartScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCN");

                entity.Property(e => e.TxData)
                    .HasColumnType("BLOB")
                    .HasColumnName("TX_DATA");
            });

            modelBuilder.Entity<LogmnrSeed>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol })
                    .HasName("LOGMNR_SEED$_PK");

                entity.ToTable("LOGMNR_SEED$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol }, "LOGMNR_I1SEED$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Schemaname, e.TableName, e.ColName, e.Obj, e.Intcol }, "LOGMNR_I2SEED$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Col)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COL#");

                entity.Property(e => e.ColName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("COL_NAME");

                entity.Property(e => e.GatherVersion)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("GATHER_VERSION");

                entity.Property(e => e.Length)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LENGTH");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Null)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NULL$");

                entity.Property(e => e.Objv)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OBJV#");

                entity.Property(e => e.Precision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRECISION#");

                entity.Property(e => e.Scale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCALE");

                entity.Property(e => e.Schemaname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SCHEMANAME");

                entity.Property(e => e.SeedVersion)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("SEED_VERSION");

                entity.Property(e => e.Segcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEGCOL#");

                entity.Property(e => e.TableName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPE#");
            });

            modelBuilder.Entity<LogmnrSession>(entity =>
            {
                entity.HasKey(e => e.Session)
                    .HasName("LOGMNR_SESSION_PK");

                entity.ToTable("LOGMNR_SESSION$");

                entity.HasIndex(e => e.SessionName, "LOGMNR_SESSION_UK1")
                    .IsUnique();

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.BranchScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_SCN");

                entity.Property(e => e.Client)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CLIENT#");

                entity.Property(e => e.DbId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DB_ID");

                entity.Property(e => e.EndScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("END_SCN");

                entity.Property(e => e.GlobalDbName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_DB_NAME")
                    .HasDefaultValueSql("null");

                entity.Property(e => e.OldestScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OLDEST_SCN");

                entity.Property(e => e.PurgeScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PURGE_SCN");

                entity.Property(e => e.RedoCompat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REDO_COMPAT");

                entity.Property(e => e.ResetTimestamp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESET_TIMESTAMP");

                entity.Property(e => e.ResetlogsChange)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESETLOGS_CHANGE#");

                entity.Property(e => e.ResumeScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESUME_SCN");

                entity.Property(e => e.SessionAttr)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION_ATTR");

                entity.Property(e => e.SessionAttrVerbose)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("SESSION_ATTR_VERBOSE");

                entity.Property(e => e.SessionName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SESSION_NAME");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE5");

                entity.Property(e => e.Spare6)
                    .HasColumnType("DATE")
                    .HasColumnName("SPARE6");

                entity.Property(e => e.Spare7)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE7");

                entity.Property(e => e.Spare8)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE8");

                entity.Property(e => e.Spare9)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE9");

                entity.Property(e => e.SpillScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPILL_SCN");

                entity.Property(e => e.SpillTime)
                    .HasColumnType("DATE")
                    .HasColumnName("SPILL_TIME");

                entity.Property(e => e.StartScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCN");

                entity.Property(e => e.Version)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<LogmnrSessionAction>(entity =>
            {
                entity.HasKey(e => new { e.Logmnrsession, e.Actionname })
                    .HasName("LOGMNR_SESSION_ACTION$_PK");

                entity.ToTable("LOGMNR_SESSION_ACTIONS$");

                entity.Property(e => e.Logmnrsession)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNRSESSION#");

                entity.Property(e => e.Actionname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ACTIONNAME");

                entity.Property(e => e.Actiontype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACTIONTYPE#");

                entity.Property(e => e.Attr1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTR1");

                entity.Property(e => e.Attr2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTR2");

                entity.Property(e => e.Attr3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTR3");

                entity.Property(e => e.Createtime)
                    .HasPrecision(6)
                    .HasColumnName("CREATETIME");

                entity.Property(e => e.Dispatchtime)
                    .HasPrecision(6)
                    .HasColumnName("DISPATCHTIME");

                entity.Property(e => e.Dropscn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DROPSCN");

                entity.Property(e => e.Droptime)
                    .HasPrecision(6)
                    .HasColumnName("DROPTIME");

                entity.Property(e => e.Endscn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENDSCN");

                entity.Property(e => e.Endsubscn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENDSUBSCN");

                entity.Property(e => e.Flagsdefinetime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGSDEFINETIME");

                entity.Property(e => e.Flagsruntime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGSRUNTIME")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Lcrcount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LCRCOUNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modifytime)
                    .HasPrecision(6)
                    .HasColumnName("MODIFYTIME");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.PdbName)
                    .HasMaxLength(390)
                    .IsUnicode(false)
                    .HasColumnName("PDB_NAME");

                entity.Property(e => e.Pdbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDBID");

                entity.Property(e => e.Processrole)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROCESSROLE#");

                entity.Property(e => e.Rbablk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RBABLK");

                entity.Property(e => e.Rbabyte)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RBABYTE");

                entity.Property(e => e.Rbasqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RBASQN");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasPrecision(6)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Startscn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STARTSCN");

                entity.Property(e => e.Startsubscn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STARTSUBSCN");

                entity.Property(e => e.Thread)
                    .HasColumnType("NUMBER")
                    .HasColumnName("THREAD#");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");
            });

            modelBuilder.Entity<LogmnrSessionEvolve>(entity =>
            {
                entity.HasKey(e => new { e.Session, e.DbId, e.ResetScn, e.ResetTimestamp })
                    .HasName("LOGMNR_SESSION_EVOLVE$_PK");

                entity.ToTable("LOGMNR_SESSION_EVOLVE$");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.DbId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DB_ID");

                entity.Property(e => e.ResetScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESET_SCN");

                entity.Property(e => e.ResetTimestamp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESET_TIMESTAMP");

                entity.Property(e => e.BranchLevel)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_LEVEL");

                entity.Property(e => e.PrevResetScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PREV_RESET_SCN");

                entity.Property(e => e.PrevResetTimestamp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PREV_RESET_TIMESTAMP");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasColumnType("DATE")
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<LogmnrShardT>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.TablespaceName })
                    .HasName("LOGMNR_SHARD_TS_PK");

                entity.ToTable("LOGMNR_SHARD_TS");

                entity.HasIndex(e => new { e.LogmnrUid, e.TablespaceName }, "LOGMNR_I1SHARD_TS");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.TablespaceName)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("TABLESPACE_NAME");

                entity.Property(e => e.ChunkNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHUNK_NUMBER");

                entity.Property(e => e.StartScnbas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCNBAS");

                entity.Property(e => e.StartScnwrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCNWRP");
            });

            modelBuilder.Entity<LogmnrSpill>(entity =>
            {
                entity.HasKey(e => new { e.Session, e.Pdbid, e.Xidusn, e.Xidslt, e.Xidsqn, e.Chunk, e.Startidx, e.Endidx, e.Flag, e.Sequence })
                    .HasName("LOGMNR_SPILL$_PK");

                entity.ToTable("LOGMNR_SPILL$");

                entity.Property(e => e.Session)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION#");

                entity.Property(e => e.Pdbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDBID");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.Chunk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHUNK");

                entity.Property(e => e.Startidx)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STARTIDX");

                entity.Property(e => e.Endidx)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENDIDX");

                entity.Property(e => e.Flag)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAG");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.SpillData)
                    .HasColumnType("BLOB")
                    .HasColumnName("SPILL_DATA");
            });

            modelBuilder.Entity<LogmnrSubcoltype>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Intcol, e.Toid })
                    .HasName("LOGMNR_SUBCOLTYPE$_PK");

                entity.ToTable("LOGMNR_SUBCOLTYPE$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Intcol, e.Toid }, "LOGMNR_I1SUBCOLTYPE$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Toid).HasColumnName("TOID");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.IntcolS1).HasColumnName("INTCOL#S");

                entity.Property(e => e.Intcols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOLS");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Synobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SYNOBJ#");

                entity.Property(e => e.Version)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VERSION#");
            });

            modelBuilder.Entity<LogmnrT>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Ts })
                    .HasName("LOGMNR_TS$_PK");

                entity.ToTable("LOGMNR_TS$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Ts }, "LOGMNR_I1TS$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Ts)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("TS#");

                entity.Property(e => e.Blocksize)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("BLOCKSIZE");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Owner)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OWNER#");

                entity.Property(e => e.StartScnbas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCNBAS");

                entity.Property(e => e.StartScnwrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCNWRP");
            });

            modelBuilder.Entity<LogmnrTab>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj })
                    .HasName("LOGMNR_TAB$_PK");

                entity.ToTable("LOGMNR_TAB$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj }, "LOGMNR_I1TAB$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Bobj }, "LOGMNR_I2TAB$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Acdrflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRFLAGS");

                entity.Property(e => e.Acdrrowtsintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRROWTSINTCOL#");

                entity.Property(e => e.Acdrtsobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRTSOBJ#");

                entity.Property(e => e.Bobj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("BOBJ#");

                entity.Property(e => e.Cols)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("COLS");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Intcols)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("INTCOLS");

                entity.Property(e => e.Kernelcols)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("KERNELCOLS");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Property)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTY");

                entity.Property(e => e.Trigflag)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("TRIGFLAG");

                entity.Property(e => e.Ts)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("TS#");
            });

            modelBuilder.Entity<LogmnrTabcompart>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj })
                    .HasName("LOGMNR_TABCOMPART$_PK");

                entity.ToTable("LOGMNR_TABCOMPART$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj }, "LOGMNR_I1TABCOMPART$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Bo }, "LOGMNR_I2TABCOMPART$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Bo)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("BO#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Part)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("PART#");
            });

            modelBuilder.Entity<LogmnrTabpart>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Bo })
                    .HasName("LOGMNR_TABPART$_PK");

                entity.ToTable("LOGMNR_TABPART$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Bo }, "LOGMNR_I1TABPART$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Bo }, "LOGMNR_I2TABPART$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Bo)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("BO#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Part)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PART#");

                entity.Property(e => e.Ts)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("TS#");
            });

            modelBuilder.Entity<LogmnrTabsubpart>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Pobj })
                    .HasName("LOGMNR_TABSUBPART$_PK");

                entity.ToTable("LOGMNR_TABSUBPART$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Pobj }, "LOGMNR_I1TABSUBPART$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Pobj }, "LOGMNR_I2TABSUBPART$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Pobj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("POBJ#");

                entity.Property(e => e.Dataobj)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("DATAOBJ#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Subpart)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("SUBPART#");

                entity.Property(e => e.Ts)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("TS#");
            });

            modelBuilder.Entity<LogmnrType>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Toid, e.Version })
                    .HasName("LOGMNR_TYPE$_PK");

                entity.ToTable("LOGMNR_TYPE$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Toid, e.Version }, "LOGMNR_I1TYPE$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Toid).HasColumnName("TOID");

                entity.Property(e => e.Version)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VERSION#");

                entity.Property(e => e.Attributes)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTRIBUTES");

                entity.Property(e => e.Externname)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNNAME");

                entity.Property(e => e.Externtype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EXTERNTYPE");

                entity.Property(e => e.Hashcode)
                    .HasMaxLength(17)
                    .HasColumnName("HASHCODE");

                entity.Property(e => e.Helperclassname)
                    .IsUnicode(false)
                    .HasColumnName("HELPERCLASSNAME");

                entity.Property(e => e.Hiddenmethods)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HIDDENMETHODS");

                entity.Property(e => e.LocalAttrs)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOCAL_ATTRS");

                entity.Property(e => e.LocalMethods)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOCAL_METHODS");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Methods)
                    .HasColumnType("NUMBER")
                    .HasColumnName("METHODS");

                entity.Property(e => e.Properties)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTIES");

                entity.Property(e => e.Roottoid).HasColumnName("ROOTTOID");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Subtypes)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBTYPES");

                entity.Property(e => e.Supertoid).HasColumnName("SUPERTOID");

                entity.Property(e => e.Supertypes)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUPERTYPES");

                entity.Property(e => e.Tvoid).HasColumnName("TVOID");

                entity.Property(e => e.Typecode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPECODE");

                entity.Property(e => e.Typeid).HasColumnName("TYPEID");

                entity.Property(e => e.Version1)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<LogmnrUid>(entity =>
            {
                entity.HasKey(e => e.LogmnrUid1)
                    .HasName("LOGMNR_UID$_PK");

                entity.ToTable("LOGMNR_UID$");

                entity.Property(e => e.LogmnrUid1)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.EndScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("END_SCN");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.LogmnrDid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_DID");

                entity.Property(e => e.LogmnrMdh)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_MDH");

                entity.Property(e => e.PdbId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDB_ID");

                entity.Property(e => e.PdbName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PDB_NAME");

                entity.Property(e => e.PdbUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDB_UID");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasPrecision(6)
                    .HasColumnName("SPARE4");

                entity.Property(e => e.StartScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCN");
            });

            modelBuilder.Entity<LogmnrUser>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.User })
                    .HasName("LOGMNR_USER$_PK");

                entity.ToTable("LOGMNR_USER$");

                entity.HasIndex(e => new { e.LogmnrUid, e.User }, "LOGMNR_I1USER$");

                entity.HasIndex(e => new { e.LogmnrUid, e.Name }, "LOGMNR_I2USER$");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.User)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("USER#");

                entity.Property(e => e.LogmnrFlags)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("LOGMNR_FLAGS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<LogmnrcConGg>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Con, e.CommitScn })
                    .HasName("LOGMNRC_CON_GG_PK");

                entity.ToTable("LOGMNRC_CON_GG");

                entity.HasIndex(e => new { e.LogmnrUid, e.Baseobj, e.Baseobjv, e.CommitScn }, "LOGMNRC_I1CONGG");

                entity.HasIndex(e => new { e.LogmnrUid, e.DropScn }, "LOGMNRC_I2CONGG");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Con)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CON#");

                entity.Property(e => e.CommitScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMMIT_SCN");

                entity.Property(e => e.Baseobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASEOBJ#");

                entity.Property(e => e.Baseobjv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASEOBJV#");

                entity.Property(e => e.DropScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DROP_SCN");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Indexobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INDEXOBJ#");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .IsUnicode(false)
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .IsUnicode(false)
                    .HasColumnName("SPARE5");

                entity.Property(e => e.Spare6)
                    .IsUnicode(false)
                    .HasColumnName("SPARE6");
            });

            modelBuilder.Entity<LogmnrcConcolGg>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Con, e.CommitScn, e.Intcol })
                    .HasName("LOGMNRC_CONCOL_GG_PK");

                entity.ToTable("LOGMNRC_CONCOL_GG");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Con)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CON#");

                entity.Property(e => e.CommitScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMMIT_SCN");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Pos)
                    .HasColumnType("NUMBER")
                    .HasColumnName("POS#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");
            });

            modelBuilder.Entity<LogmnrcDbnameUidMap>(entity =>
            {
                entity.HasKey(e => new { e.GlobalName, e.LogmnrMdh })
                    .HasName("LOGMNRC_DBNAME_UID_MAP_PK");

                entity.ToTable("LOGMNRC_DBNAME_UID_MAP");

                entity.Property(e => e.GlobalName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_NAME");

                entity.Property(e => e.LogmnrMdh)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_MDH");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.PdbName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PDB_NAME");
            });

            modelBuilder.Entity<LogmnrcGsba>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.AsOfScn })
                    .HasName("LOGMNRC_GSBA_PK");

                entity.ToTable("LOGMNRC_GSBA");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.AsOfScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AS_OF_SCN");

                entity.Property(e => e.Charsetid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHARSETID");

                entity.Property(e => e.DbGlobalName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("DB_GLOBAL_NAME");

                entity.Property(e => e.DbtimezoneLen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DBTIMEZONE_LEN");

                entity.Property(e => e.DbtimezoneValue)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("DBTIMEZONE_VALUE");

                entity.Property(e => e.FdoLength)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FDO_LENGTH");

                entity.Property(e => e.FdoValue)
                    .HasMaxLength(255)
                    .HasColumnName("FDO_VALUE");

                entity.Property(e => e.LogmnrSpare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE1");

                entity.Property(e => e.LogmnrSpare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE2");

                entity.Property(e => e.LogmnrSpare3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOGMNR_SPARE3");

                entity.Property(e => e.LogmnrSpare4)
                    .HasColumnType("DATE")
                    .HasColumnName("LOGMNR_SPARE4");

                entity.Property(e => e.Ncharsetid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NCHARSETID");
            });

            modelBuilder.Entity<LogmnrcGsii>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj })
                    .HasName("LOGMNRC_GSII_PK");

                entity.ToTable("LOGMNRC_GSII");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Bo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BO#");

                entity.Property(e => e.DropScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DROP_SCN");

                entity.Property(e => e.Indtype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INDTYPE#");

                entity.Property(e => e.LogmnrSpare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE1");

                entity.Property(e => e.LogmnrSpare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE2");

                entity.Property(e => e.LogmnrSpare3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOGMNR_SPARE3");

                entity.Property(e => e.LogmnrSpare4)
                    .HasColumnType("DATE")
                    .HasColumnName("LOGMNR_SPARE4");
            });

            modelBuilder.Entity<LogmnrcGtc>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Objv, e.Intcol })
                    .HasName("LOGMNRC_GTCS_PK");

                entity.ToTable("LOGMNRC_GTCS");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Objv, e.Segcol, e.Intcol }, "LOGMNRC_I2GTCS");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Objv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJV#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Acdrrescol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRRESCOL#");

                entity.Property(e => e.Adtorder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADTORDER");

                entity.Property(e => e.Charsetform)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHARSETFORM");

                entity.Property(e => e.Charsetid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHARSETID");

                entity.Property(e => e.Col)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COL#");

                entity.Property(e => e.Collid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLLID");

                entity.Property(e => e.Collintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLLINTCOL#");

                entity.Property(e => e.Colname)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("COLNAME");

                entity.Property(e => e.Eacolklc).HasColumnName("EACOLKLC");

                entity.Property(e => e.Eaencalg)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EAENCALG");

                entity.Property(e => e.Eaflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EAFLAGS");

                entity.Property(e => e.Eaintalg)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EAINTALG");

                entity.Property(e => e.Eaklclen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EAKLCLEN");

                entity.Property(e => e.Eamkeyid)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("EAMKEYID");

                entity.Property(e => e.Eaowner)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EAOWNER#");

                entity.Property(e => e.Fqcolname)
                    .IsUnicode(false)
                    .HasColumnName("FQCOLNAME");

                entity.Property(e => e.IntervalLeadingPrecision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTERVAL_LEADING_PRECISION");

                entity.Property(e => e.IntervalTrailingPrecision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTERVAL_TRAILING_PRECISION");

                entity.Property(e => e.Length)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LENGTH");

                entity.Property(e => e.LogmnrSpare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE1");

                entity.Property(e => e.LogmnrSpare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE2");

                entity.Property(e => e.LogmnrSpare3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOGMNR_SPARE3");

                entity.Property(e => e.LogmnrSpare4)
                    .HasColumnType("DATE")
                    .HasColumnName("LOGMNR_SPARE4");

                entity.Property(e => e.LogmnrSpare5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE5");

                entity.Property(e => e.LogmnrSpare6)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE6");

                entity.Property(e => e.LogmnrSpare7)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE7");

                entity.Property(e => e.LogmnrSpare8)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE8");

                entity.Property(e => e.LogmnrSpare9)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE9");

                entity.Property(e => e.Logmnrderivedflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNRDERIVEDFLAGS");

                entity.Property(e => e.Numattrs)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMATTRS");

                entity.Property(e => e.Numintcols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMINTCOLS");

                entity.Property(e => e.Precision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRECISION");

                entity.Property(e => e.Property)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTY");

                entity.Property(e => e.Scale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCALE");

                entity.Property(e => e.Segcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEGCOL#");

                entity.Property(e => e.Toid).HasColumnName("TOID");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPE#");

                entity.Property(e => e.Typename)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("TYPENAME");

                entity.Property(e => e.Xcoltypeflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XCOLTYPEFLAGS");

                entity.Property(e => e.Xfqcolname)
                    .IsUnicode(false)
                    .HasColumnName("XFQCOLNAME");

                entity.Property(e => e.Xopqlobintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XOPQLOBINTCOL");

                entity.Property(e => e.Xopqobjintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XOPQOBJINTCOL");

                entity.Property(e => e.Xopqtypeflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XOPQTYPEFLAGS");

                entity.Property(e => e.Xopqtypetype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XOPQTYPETYPE");

                entity.Property(e => e.Xreffedtableobjn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XREFFEDTABLEOBJN");

                entity.Property(e => e.Xreffedtableobjv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XREFFEDTABLEOBJV");

                entity.Property(e => e.Xtopintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XTOPINTCOL");

                entity.Property(e => e.Xtypename)
                    .IsUnicode(false)
                    .HasColumnName("XTYPENAME");

                entity.Property(e => e.Xtypeschemaname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("XTYPESCHEMANAME");

                entity.Property(e => e.Xxmlintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XXMLINTCOL");
            });

            modelBuilder.Entity<LogmnrcGtlo>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Keyobj, e.Baseobjv })
                    .HasName("LOGMNRC_GTLO_PK");

                entity.ToTable("LOGMNRC_GTLO");

                entity.HasIndex(e => new { e.LogmnrUid, e.Baseobj, e.Baseobjv }, "LOGMNRC_I2GTLO");

                entity.HasIndex(e => new { e.LogmnrUid, e.DropScn }, "LOGMNRC_I3GTLO");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Keyobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KEYOBJ#");

                entity.Property(e => e.Baseobjv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASEOBJV#");

                entity.Property(e => e.Acdrflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRFLAGS");

                entity.Property(e => e.Acdrrowtsintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRROWTSINTCOL#");

                entity.Property(e => e.Acdrtsobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRTSOBJ#");

                entity.Property(e => e.Assoc)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSOC#");

                entity.Property(e => e.Baseobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASEOBJ#");

                entity.Property(e => e.Cols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLS");

                entity.Property(e => e.Complextypecols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMPLEXTYPECOLS");

                entity.Property(e => e.DropScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DROP_SCN");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Intcols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOLS");

                entity.Property(e => e.Kernelcols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KERNELCOLS");

                entity.Property(e => e.LogmnrSpare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE1");

                entity.Property(e => e.LogmnrSpare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE2");

                entity.Property(e => e.LogmnrSpare3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOGMNR_SPARE3");

                entity.Property(e => e.LogmnrSpare4)
                    .HasColumnType("DATE")
                    .HasColumnName("LOGMNR_SPARE4");

                entity.Property(e => e.LogmnrSpare5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE5");

                entity.Property(e => e.LogmnrSpare6)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE6");

                entity.Property(e => e.LogmnrSpare7)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE7");

                entity.Property(e => e.LogmnrSpare8)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE8");

                entity.Property(e => e.LogmnrSpare9)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE9");

                entity.Property(e => e.Logmnrmcv)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LOGMNRMCV");

                entity.Property(e => e.Logmnrtloflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNRTLOFLAGS");

                entity.Property(e => e.Lvl0name)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("LVL0NAME");

                entity.Property(e => e.Lvl0type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVL0TYPE#");

                entity.Property(e => e.Lvl1name)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("LVL1NAME");

                entity.Property(e => e.Lvl1obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVL1OBJ#");

                entity.Property(e => e.Lvl1type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVL1TYPE#");

                entity.Property(e => e.Lvl2name)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("LVL2NAME");

                entity.Property(e => e.Lvl2obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVL2OBJ#");

                entity.Property(e => e.Lvl2type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVL2TYPE#");

                entity.Property(e => e.Lvlcnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVLCNT");

                entity.Property(e => e.Ntparentintcolnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NTPARENTINTCOLNUM");

                entity.Property(e => e.Ntparentobjnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NTPARENTOBJNUM");

                entity.Property(e => e.Ntparentobjversion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NTPARENTOBJVERSION");

                entity.Property(e => e.ObjFlags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ_FLAGS");

                entity.Property(e => e.Owner)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OWNER#");

                entity.Property(e => e.Ownername)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("OWNERNAME");

                entity.Property(e => e.Parttype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARTTYPE");

                entity.Property(e => e.Property)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTY");

                entity.Property(e => e.StartScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCN");

                entity.Property(e => e.Subparttype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBPARTTYPE");

                entity.Property(e => e.TabFlags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TAB_FLAGS");

                entity.Property(e => e.Trigflag)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRIGFLAG");

                entity.Property(e => e.Ts)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TS#");

                entity.Property(e => e.Tsname)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("TSNAME");

                entity.Property(e => e.Unsupportedcols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UNSUPPORTEDCOLS");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");
            });

            modelBuilder.Entity<LogmnrcIndGg>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.CommitScn })
                    .HasName("LOGMNRC_IND_GG_PK");

                entity.ToTable("LOGMNRC_IND_GG");

                entity.HasIndex(e => new { e.LogmnrUid, e.Baseobj, e.Baseobjv, e.CommitScn }, "LOGMNRC_I1INDGG");

                entity.HasIndex(e => new { e.LogmnrUid, e.DropScn }, "LOGMNRC_I2INDGG");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.CommitScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMMIT_SCN");

                entity.Property(e => e.Baseobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASEOBJ#");

                entity.Property(e => e.Baseobjv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASEOBJV#");

                entity.Property(e => e.DropScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DROP_SCN");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Owner)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OWNER#");

                entity.Property(e => e.Ownername)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("OWNERNAME");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .IsUnicode(false)
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .IsUnicode(false)
                    .HasColumnName("SPARE5");

                entity.Property(e => e.Spare6)
                    .IsUnicode(false)
                    .HasColumnName("SPARE6");
            });

            modelBuilder.Entity<LogmnrcIndcolGg>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.CommitScn, e.Intcol })
                    .HasName("LOGMNRC_INDCOL_GG_PK");

                entity.ToTable("LOGMNRC_INDCOL_GG");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.CommitScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMMIT_SCN");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Pos)
                    .HasColumnType("NUMBER")
                    .HasColumnName("POS#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");
            });

            modelBuilder.Entity<LogmnrcSeqGg>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.CommitScn })
                    .HasName("LOGMNRC_SEQ_GG_PK");

                entity.ToTable("LOGMNRC_SEQ_GG");

                entity.HasIndex(e => new { e.LogmnrUid, e.DropScn }, "LOGMNRC_I2SEQGG");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.CommitScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMMIT_SCN");

                entity.Property(e => e.DropScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DROP_SCN");

                entity.Property(e => e.Objname)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("OBJNAME");

                entity.Property(e => e.Owner)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OWNER#");

                entity.Property(e => e.Ownername)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("OWNERNAME");

                entity.Property(e => e.SeqFlags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ_FLAGS");

                entity.Property(e => e.Seqcache)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQCACHE");

                entity.Property(e => e.Seqinc)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQINC");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .IsUnicode(false)
                    .HasColumnName("SPARE4");
            });

            modelBuilder.Entity<LogmnrcShardT>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.TablespaceName, e.StartScn })
                    .HasName("LOGMNRC_SHARD_TS_PK");

                entity.ToTable("LOGMNRC_SHARD_TS");

                entity.HasIndex(e => new { e.LogmnrUid, e.DropScn }, "LOGMNRC_I1SHARD_TS");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.TablespaceName)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("TABLESPACE_NAME");

                entity.Property(e => e.StartScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCN");

                entity.Property(e => e.ChunkNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHUNK_NUMBER");

                entity.Property(e => e.DropScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DROP_SCN");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");
            });

            modelBuilder.Entity<LogmnrcT>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Ts, e.StartScn })
                    .HasName("LOGMNRC_TS_PK");

                entity.ToTable("LOGMNRC_TS");

                entity.HasIndex(e => new { e.LogmnrUid, e.DropScn }, "LOGMNRC_I1TS");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Ts)
                    .HasColumnType("NUMBER(22)")
                    .HasColumnName("TS#");

                entity.Property(e => e.StartScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCN");

                entity.Property(e => e.DropScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DROP_SCN");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");
            });

            modelBuilder.Entity<LogmnrcTspart>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.StartScn })
                    .HasName("LOGMNRC_TSPART_PK");

                entity.ToTable("LOGMNRC_TSPART");

                entity.HasIndex(e => new { e.LogmnrUid, e.DropScn }, "LOGMNRC_I1TSPART");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.StartScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCN");

                entity.Property(e => e.DropScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DROP_SCN");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Ts)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TS#");
            });

            modelBuilder.Entity<LogmnrggcGtc>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Obj, e.Objv, e.Intcol })
                    .HasName("LOGMNRGGC_GTCS_PK");

                entity.ToTable("LOGMNRGGC_GTCS");

                entity.HasIndex(e => new { e.LogmnrUid, e.Obj, e.Objv, e.Segcol, e.Intcol }, "LOGMNRGGC_I2GTCS");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Objv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJV#");

                entity.Property(e => e.Intcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOL#");

                entity.Property(e => e.Acdrrescol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRRESCOL#");

                entity.Property(e => e.Adtorder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADTORDER");

                entity.Property(e => e.Charsetform)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHARSETFORM");

                entity.Property(e => e.Charsetid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHARSETID");

                entity.Property(e => e.Col)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COL#");

                entity.Property(e => e.Collid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLLID");

                entity.Property(e => e.Collintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLLINTCOL#");

                entity.Property(e => e.Colname)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("COLNAME");

                entity.Property(e => e.Eacolklc).HasColumnName("EACOLKLC");

                entity.Property(e => e.Eaencalg)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EAENCALG");

                entity.Property(e => e.Eaflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EAFLAGS");

                entity.Property(e => e.Eaintalg)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EAINTALG");

                entity.Property(e => e.Eaklclen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EAKLCLEN");

                entity.Property(e => e.Eamkeyid)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("EAMKEYID");

                entity.Property(e => e.Eaowner)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EAOWNER#");

                entity.Property(e => e.Fqcolname)
                    .IsUnicode(false)
                    .HasColumnName("FQCOLNAME");

                entity.Property(e => e.IntervalLeadingPrecision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTERVAL_LEADING_PRECISION");

                entity.Property(e => e.IntervalTrailingPrecision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTERVAL_TRAILING_PRECISION");

                entity.Property(e => e.Length)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LENGTH");

                entity.Property(e => e.LogmnrSpare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE1");

                entity.Property(e => e.LogmnrSpare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE2");

                entity.Property(e => e.LogmnrSpare3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOGMNR_SPARE3");

                entity.Property(e => e.LogmnrSpare4)
                    .HasColumnType("DATE")
                    .HasColumnName("LOGMNR_SPARE4");

                entity.Property(e => e.LogmnrSpare5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE5");

                entity.Property(e => e.LogmnrSpare6)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE6");

                entity.Property(e => e.LogmnrSpare7)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE7");

                entity.Property(e => e.LogmnrSpare8)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE8");

                entity.Property(e => e.LogmnrSpare9)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE9");

                entity.Property(e => e.Logmnrderivedflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNRDERIVEDFLAGS");

                entity.Property(e => e.Numattrs)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMATTRS");

                entity.Property(e => e.Numintcols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMINTCOLS");

                entity.Property(e => e.Precision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRECISION");

                entity.Property(e => e.Property)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTY");

                entity.Property(e => e.Scale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCALE");

                entity.Property(e => e.Segcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEGCOL#");

                entity.Property(e => e.Toid).HasColumnName("TOID");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPE#");

                entity.Property(e => e.Typename)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("TYPENAME");

                entity.Property(e => e.Xcoltypeflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XCOLTYPEFLAGS");

                entity.Property(e => e.Xfqcolname)
                    .IsUnicode(false)
                    .HasColumnName("XFQCOLNAME");

                entity.Property(e => e.Xopqlobintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XOPQLOBINTCOL");

                entity.Property(e => e.Xopqobjintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XOPQOBJINTCOL");

                entity.Property(e => e.Xopqtypeflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XOPQTYPEFLAGS");

                entity.Property(e => e.Xopqtypetype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XOPQTYPETYPE");

                entity.Property(e => e.Xreffedtableobjn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XREFFEDTABLEOBJN");

                entity.Property(e => e.Xreffedtableobjv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XREFFEDTABLEOBJV");

                entity.Property(e => e.Xtopintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XTOPINTCOL");

                entity.Property(e => e.Xtypename)
                    .IsUnicode(false)
                    .HasColumnName("XTYPENAME");

                entity.Property(e => e.Xtypeschemaname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("XTYPESCHEMANAME");

                entity.Property(e => e.Xxmlintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XXMLINTCOL");
            });

            modelBuilder.Entity<LogmnrggcGtlo>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Keyobj, e.Baseobjv })
                    .HasName("LOGMNRGGC_GTLO_PK");

                entity.ToTable("LOGMNRGGC_GTLO");

                entity.HasIndex(e => new { e.LogmnrUid, e.Baseobj, e.Baseobjv }, "LOGMNRGGC_I2GTLO");

                entity.HasIndex(e => new { e.LogmnrUid, e.DropScn }, "LOGMNRGGC_I3GTLO");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Keyobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KEYOBJ#");

                entity.Property(e => e.Baseobjv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASEOBJV#");

                entity.Property(e => e.Acdrflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRFLAGS");

                entity.Property(e => e.Acdrrowtsintcol)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRROWTSINTCOL#");

                entity.Property(e => e.Acdrtsobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACDRTSOBJ#");

                entity.Property(e => e.Assoc)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSOC#");

                entity.Property(e => e.Baseobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASEOBJ#");

                entity.Property(e => e.Cols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLS");

                entity.Property(e => e.Complextypecols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMPLEXTYPECOLS");

                entity.Property(e => e.DropScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DROP_SCN");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Intcols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTCOLS");

                entity.Property(e => e.Kernelcols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KERNELCOLS");

                entity.Property(e => e.LogmnrSpare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE1");

                entity.Property(e => e.LogmnrSpare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE2");

                entity.Property(e => e.LogmnrSpare3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOGMNR_SPARE3");

                entity.Property(e => e.LogmnrSpare4)
                    .HasColumnType("DATE")
                    .HasColumnName("LOGMNR_SPARE4");

                entity.Property(e => e.LogmnrSpare5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE5");

                entity.Property(e => e.LogmnrSpare6)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE6");

                entity.Property(e => e.LogmnrSpare7)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE7");

                entity.Property(e => e.LogmnrSpare8)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE8");

                entity.Property(e => e.LogmnrSpare9)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_SPARE9");

                entity.Property(e => e.Logmnrmcv)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LOGMNRMCV");

                entity.Property(e => e.Logmnrtloflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNRTLOFLAGS");

                entity.Property(e => e.Lvl0name)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("LVL0NAME");

                entity.Property(e => e.Lvl0type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVL0TYPE#");

                entity.Property(e => e.Lvl1name)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("LVL1NAME");

                entity.Property(e => e.Lvl1obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVL1OBJ#");

                entity.Property(e => e.Lvl1type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVL1TYPE#");

                entity.Property(e => e.Lvl2name)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("LVL2NAME");

                entity.Property(e => e.Lvl2obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVL2OBJ#");

                entity.Property(e => e.Lvl2type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVL2TYPE#");

                entity.Property(e => e.Lvlcnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LVLCNT");

                entity.Property(e => e.Ntparentintcolnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NTPARENTINTCOLNUM");

                entity.Property(e => e.Ntparentobjnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NTPARENTOBJNUM");

                entity.Property(e => e.Ntparentobjversion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NTPARENTOBJVERSION");

                entity.Property(e => e.ObjFlags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ_FLAGS");

                entity.Property(e => e.Owner)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OWNER#");

                entity.Property(e => e.Ownername)
                    .IsRequired()
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("OWNERNAME");

                entity.Property(e => e.Parttype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARTTYPE");

                entity.Property(e => e.Property)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPERTY");

                entity.Property(e => e.StartScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_SCN");

                entity.Property(e => e.Subparttype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBPARTTYPE");

                entity.Property(e => e.TabFlags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TAB_FLAGS");

                entity.Property(e => e.Trigflag)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRIGFLAG");

                entity.Property(e => e.Ts)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TS#");

                entity.Property(e => e.Tsname)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("TSNAME");

                entity.Property(e => e.Unsupportedcols)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UNSUPPORTEDCOLS");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");
            });

            modelBuilder.Entity<LogmnrpCtasPartMap>(entity =>
            {
                entity.HasKey(e => new { e.LogmnrUid, e.Baseobjv, e.Keyobj })
                    .HasName("LOGMNRP_CTAS_PART_MAP_PK");

                entity.ToTable("LOGMNRP_CTAS_PART_MAP");

                entity.HasIndex(e => new { e.LogmnrUid, e.Baseobj, e.Baseobjv, e.Part }, "LOGMNRP_CTAS_PART_MAP_I");

                entity.Property(e => e.LogmnrUid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOGMNR_UID");

                entity.Property(e => e.Baseobjv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASEOBJV#");

                entity.Property(e => e.Keyobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KEYOBJ#");

                entity.Property(e => e.Baseobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BASEOBJ#");

                entity.Property(e => e.Part)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PART#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");
            });

            modelBuilder.Entity<LogmnrtMddl>(entity =>
            {
                entity.HasKey(e => new { e.SourceObj, e.SourceRowid })
                    .HasName("LOGMNRT_MDDL$_PK");

                entity.ToTable("LOGMNRT_MDDL$");

                entity.Property(e => e.SourceObj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SOURCE_OBJ#");

                entity.Property(e => e.SourceRowid)
                    .HasColumnType("ROWID")
                    .HasColumnName("SOURCE_ROWID");

                entity.Property(e => e.DestRowid)
                    .IsRequired()
                    .HasColumnType("ROWID")
                    .HasColumnName("DEST_ROWID");
            });

            modelBuilder.Entity<LogstdbyApplyMilestone>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGSTDBY$APPLY_MILESTONE");

                entity.Property(e => e.CommitScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMMIT_SCN");

                entity.Property(e => e.CommitTime)
                    .HasColumnType("DATE")
                    .HasColumnName("COMMIT_TIME");

                entity.Property(e => e.Epoch)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EPOCH");

                entity.Property(e => e.FetchlwmScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FETCHLWM_SCN")
                    .HasDefaultValueSql("(0) ");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.LwmUpdTime)
                    .HasColumnType("DATE")
                    .HasColumnName("LWM_UPD_TIME");

                entity.Property(e => e.ProcessedScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROCESSED_SCN");

                entity.Property(e => e.ProcessedTime)
                    .HasColumnType("DATE")
                    .HasColumnName("PROCESSED_TIME");

                entity.Property(e => e.PtoRecoveryIncarnation)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PTO_RECOVERY_INCARNATION");

                entity.Property(e => e.PtoRecoveryScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PTO_RECOVERY_SCN");

                entity.Property(e => e.SessionId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION_ID");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE5");

                entity.Property(e => e.Spare6)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE6");

                entity.Property(e => e.Spare7)
                    .HasColumnType("DATE")
                    .HasColumnName("SPARE7");

                entity.Property(e => e.SynchScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SYNCH_SCN");
            });

            modelBuilder.Entity<LogstdbyApplyProgress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGSTDBY$APPLY_PROGRESS");

                entity.Property(e => e.CommitScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMMIT_SCN");

                entity.Property(e => e.CommitTime)
                    .HasColumnType("DATE")
                    .HasColumnName("COMMIT_TIME");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");
            });

            modelBuilder.Entity<LogstdbyEdsTable>(entity =>
            {
                entity.HasKey(e => new { e.Owner, e.TableName })
                    .HasName("LOGSTDBY$EDS_TABLES_PKEY");

                entity.ToTable("LOGSTDBY$EDS_TABLES");

                entity.Property(e => e.Owner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.BaseTriggerName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("BASE_TRIGGER_NAME");

                entity.Property(e => e.Ctime)
                    .HasPrecision(6)
                    .HasColumnName("CTIME");

                entity.Property(e => e.Dblink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DBLINK");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.MviewLogName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("MVIEW_LOG_NAME");

                entity.Property(e => e.MviewName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("MVIEW_NAME");

                entity.Property(e => e.MviewTriggerName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("MVIEW_TRIGGER_NAME");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Objv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJV");

                entity.Property(e => e.ShadowTableName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SHADOW_TABLE_NAME");

                entity.Property(e => e.ShadowTriggerName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SHADOW_TRIGGER_NAME");

                entity.Property(e => e.Sobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SOBJ#");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STATE");
            });

            modelBuilder.Entity<LogstdbyEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGSTDBY$EVENTS");

                entity.HasIndex(e => e.EventTime, "LOGSTDBY$EVENTS_IND");

                entity.HasIndex(e => e.CommitScn, "LOGSTDBY$EVENTS_IND_SCN");

                entity.HasIndex(e => new { e.Xidusn, e.Xidslt, e.Xidsqn }, "LOGSTDBY$EVENTS_IND_XID");

                entity.Property(e => e.CommitScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMMIT_SCN");

                entity.Property(e => e.ConId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CON_ID");

                entity.Property(e => e.ConName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CON_NAME");

                entity.Property(e => e.CurrentScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CURRENT_SCN");

                entity.Property(e => e.Error)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ERROR");

                entity.Property(e => e.Errval)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ERRVAL");

                entity.Property(e => e.Event)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("EVENT");

                entity.Property(e => e.EventTime)
                    .HasPrecision(6)
                    .HasColumnName("EVENT_TIME");

                entity.Property(e => e.FullEvent)
                    .HasColumnType("CLOB")
                    .HasColumnName("FULL_EVENT");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");
            });

            modelBuilder.Entity<LogstdbyFlashbackScn>(entity =>
            {
                entity.HasKey(e => e.PrimaryScn)
                    .HasName("SYS_C004926");

                entity.ToTable("LOGSTDBY$FLASHBACK_SCN");

                entity.Property(e => e.PrimaryScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIMARY_SCN");

                entity.Property(e => e.PrimaryTime)
                    .HasColumnType("DATE")
                    .HasColumnName("PRIMARY_TIME");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("DATE")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.StandbyScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STANDBY_SCN");

                entity.Property(e => e.StandbyTime)
                    .HasColumnType("DATE")
                    .HasColumnName("STANDBY_TIME");
            });

            modelBuilder.Entity<LogstdbyHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGSTDBY$HISTORY");

                entity.Property(e => e.Dbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DBID");

                entity.Property(e => e.Dgname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DGNAME");

                entity.Property(e => e.FirstChange)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FIRST_CHANGE#");

                entity.Property(e => e.FirstTime)
                    .HasColumnType("DATE")
                    .HasColumnName("FIRST_TIME");

                entity.Property(e => e.LastChange)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_CHANGE#");

                entity.Property(e => e.LastTime)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_TIME");

                entity.Property(e => e.LmnrSid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LMNR_SID");

                entity.Property(e => e.Source)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");

                entity.Property(e => e.StreamSequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STREAM_SEQUENCE#");
            });

            modelBuilder.Entity<LogstdbyParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGSTDBY$PARAMETERS");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Scn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCN");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPE");

                entity.Property(e => e.Value)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<LogstdbyPlsql>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGSTDBY$PLSQL");

                entity.Property(e => e.CallText)
                    .HasColumnType("CLOB")
                    .HasColumnName("CALL_TEXT");

                entity.Property(e => e.SessionId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SESSION_ID");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.StartFinish)
                    .HasColumnType("NUMBER")
                    .HasColumnName("START_FINISH");
            });

            modelBuilder.Entity<LogstdbyScn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGSTDBY$SCN");

                entity.Property(e => e.Obj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OBJ#");

                entity.Property(e => e.Objname)
                    .IsUnicode(false)
                    .HasColumnName("OBJNAME");

                entity.Property(e => e.Schema)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SCHEMA");

                entity.Property(e => e.Scn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCN");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<LogstdbySkip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGSTDBY$SKIP");

                entity.HasIndex(e => new { e.UseLike, e.Schema, e.Name }, "LOGSTDBY$SKIP_IDX1");

                entity.HasIndex(e => e.StatementOpt, "LOGSTDBY$SKIP_IDX2");

                entity.Property(e => e.Active)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACTIVE");

                entity.Property(e => e.Error)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ERROR");

                entity.Property(e => e.Esc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESC");

                entity.Property(e => e.Name)
                    .HasMaxLength(261)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Proc)
                    .HasMaxLength(392)
                    .IsUnicode(false)
                    .HasColumnName("PROC");

                entity.Property(e => e.Schema)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SCHEMA");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.StatementOpt)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("STATEMENT_OPT");

                entity.Property(e => e.UseLike)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USE_LIKE");
            });

            modelBuilder.Entity<LogstdbySkipSupport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGSTDBY$SKIP_SUPPORT");

                entity.HasIndex(e => new { e.Name, e.Action }, "LOGSTDBY$SKIP_IND");

                entity.Property(e => e.Action)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACTION");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Name2)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("NAME2");

                entity.Property(e => e.Name3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("NAME3");

                entity.Property(e => e.Name4)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("NAME4");

                entity.Property(e => e.Name5)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("NAME5");

                entity.Property(e => e.Reg)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("REG");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");
            });

            modelBuilder.Entity<LogstdbySkipTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGSTDBY$SKIP_TRANSACTION");

                entity.Property(e => e.Active)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACTIVE");

                entity.Property(e => e.CommitScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMMIT_SCN");

                entity.Property(e => e.ConName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("CON_NAME");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Xidslt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSLT");

                entity.Property(e => e.Xidsqn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDSQN");

                entity.Property(e => e.Xidusn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("XIDUSN");
            });

            modelBuilder.Entity<MviewAdvAjg>(entity =>
            {
                entity.HasKey(e => e.Ajgid)
                    .HasName("MVIEW$_ADV_AJG_PK");

                entity.ToTable("MVIEW$_ADV_AJG");

                entity.Property(e => e.Ajgid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AJGID#");

                entity.Property(e => e.Ajgdes)
                    .IsRequired()
                    .HasColumnType("LONG RAW")
                    .HasColumnName("AJGDES");

                entity.Property(e => e.Ajgdeslen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AJGDESLEN");

                entity.Property(e => e.Frequency)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.Hashvalue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HASHVALUE");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.MviewAdvAjgs)
                    .HasForeignKey(d => d.Runid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_AJG_FK");
            });

            modelBuilder.Entity<MviewAdvBasetable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MVIEW$_ADV_BASETABLE");

                entity.HasIndex(e => e.Queryid, "MVIEW$_ADV_BASETABLE_IDX_01");

                entity.Property(e => e.Collectionid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLLECTIONID#");

                entity.Property(e => e.Owner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Queryid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUERYID#");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.TableType)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TABLE_TYPE");

                entity.HasOne(d => d.Query)
                    .WithMany()
                    .HasForeignKey(d => d.Queryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_BASETABLE_FK");
            });

            modelBuilder.Entity<MviewAdvClique>(entity =>
            {
                entity.HasKey(e => e.Cliqueid)
                    .HasName("MVIEW$_ADV_CLIQUE_PK");

                entity.ToTable("MVIEW$_ADV_CLIQUE");

                entity.Property(e => e.Cliqueid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CLIQUEID#");

                entity.Property(e => e.Bytecost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BYTECOST");

                entity.Property(e => e.Cliquedes)
                    .IsRequired()
                    .HasColumnType("LONG RAW")
                    .HasColumnName("CLIQUEDES");

                entity.Property(e => e.Cliquedeslen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CLIQUEDESLEN");

                entity.Property(e => e.Frequency)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.Hashvalue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HASHVALUE");

                entity.Property(e => e.Numrows)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMROWS");

                entity.Property(e => e.Rowsize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROWSIZE");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.MviewAdvCliques)
                    .HasForeignKey(d => d.Runid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_CLIQUE_FK");
            });

            modelBuilder.Entity<MviewAdvEligible>(entity =>
            {
                entity.HasKey(e => new { e.Sumobjn, e.Runid })
                    .HasName("MVIEW$_ADV_ELIGIBLE_PK");

                entity.ToTable("MVIEW$_ADV_ELIGIBLE");

                entity.Property(e => e.Sumobjn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMOBJN#");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.Property(e => e.Bytecost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BYTECOST");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Frequency)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FREQUENCY");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.MviewAdvEligibles)
                    .HasForeignKey(d => d.Runid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_ELIGIBLE_FK");
            });

            modelBuilder.Entity<MviewAdvException>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MVIEW$_ADV_EXCEPTIONS");

                entity.Property(e => e.BadRowid)
                    .HasColumnType("ROWID")
                    .HasColumnName("BAD_ROWID");

                entity.Property(e => e.DimensionName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("DIMENSION_NAME");

                entity.Property(e => e.Owner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Relationship)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONSHIP");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.HasOne(d => d.Run)
                    .WithMany()
                    .HasForeignKey(d => d.Runid)
                    .HasConstraintName("MVIEW$_ADV_EXCEPTION_FK");
            });

            modelBuilder.Entity<MviewAdvFilter>(entity =>
            {
                entity.HasKey(e => new { e.Filterid, e.Subfilternum })
                    .HasName("MVIEW$_ADV_FILTER_PK");

                entity.ToTable("MVIEW$_ADV_FILTER");

                entity.Property(e => e.Filterid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FILTERID#");

                entity.Property(e => e.Subfilternum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBFILTERNUM#");

                entity.Property(e => e.DateValue1)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE1");

                entity.Property(e => e.DateValue2)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE2");

                entity.Property(e => e.NumValue1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUM_VALUE1");

                entity.Property(e => e.NumValue2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUM_VALUE2");

                entity.Property(e => e.StrValue)
                    .HasMaxLength(1028)
                    .IsUnicode(false)
                    .HasColumnName("STR_VALUE");

                entity.Property(e => e.Subfiltertype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBFILTERTYPE");
            });

            modelBuilder.Entity<MviewAdvFilterinstance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MVIEW$_ADV_FILTERINSTANCE");

                entity.Property(e => e.DateValue1)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE1");

                entity.Property(e => e.DateValue2)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE2");

                entity.Property(e => e.Filterid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FILTERID#");

                entity.Property(e => e.NumValue1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUM_VALUE1");

                entity.Property(e => e.NumValue2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUM_VALUE2");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.Property(e => e.StrValue)
                    .HasMaxLength(1028)
                    .IsUnicode(false)
                    .HasColumnName("STR_VALUE");

                entity.Property(e => e.Subfilternum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBFILTERNUM#");

                entity.Property(e => e.Subfiltertype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBFILTERTYPE");

                entity.HasOne(d => d.Run)
                    .WithMany()
                    .HasForeignKey(d => d.Runid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_FILTERINSTANCE_FK");
            });

            modelBuilder.Entity<MviewAdvFjg>(entity =>
            {
                entity.HasKey(e => e.Fjgid)
                    .HasName("MVIEW$_ADV_FJG_PK");

                entity.ToTable("MVIEW$_ADV_FJG");

                entity.Property(e => e.Fjgid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FJGID#");

                entity.Property(e => e.Ajgid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AJGID#");

                entity.Property(e => e.Fjgdes)
                    .IsRequired()
                    .HasColumnType("LONG RAW")
                    .HasColumnName("FJGDES");

                entity.Property(e => e.Fjgdeslen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FJGDESLEN");

                entity.Property(e => e.Frequency)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.Hashvalue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HASHVALUE");

                entity.HasOne(d => d.Ajg)
                    .WithMany(p => p.MviewAdvFjgs)
                    .HasForeignKey(d => d.Ajgid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_FJG_FK");
            });

            modelBuilder.Entity<MviewAdvGc>(entity =>
            {
                entity.HasKey(e => e.Gcid)
                    .HasName("MVIEW$_ADV_GC_PK");

                entity.ToTable("MVIEW$_ADV_GC");

                entity.Property(e => e.Gcid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GCID#");

                entity.Property(e => e.Fjgid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FJGID#");

                entity.Property(e => e.Frequency)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.Gcdes)
                    .IsRequired()
                    .HasColumnType("LONG RAW")
                    .HasColumnName("GCDES");

                entity.Property(e => e.Gcdeslen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GCDESLEN");

                entity.Property(e => e.Hashvalue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HASHVALUE");

                entity.HasOne(d => d.Fjg)
                    .WithMany(p => p.MviewAdvGcs)
                    .HasForeignKey(d => d.Fjgid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_GC_FK");
            });

            modelBuilder.Entity<MviewAdvInfo>(entity =>
            {
                entity.HasKey(e => new { e.Runid, e.Seq })
                    .HasName("MVIEW$_ADV_INFO_PK");

                entity.ToTable("MVIEW$_ADV_INFO");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.Property(e => e.Seq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ#");

                entity.Property(e => e.Flag)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAG");

                entity.Property(e => e.Info)
                    .HasColumnType("LONG RAW")
                    .HasColumnName("INFO");

                entity.Property(e => e.Infolen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INFOLEN");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPE");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.MviewAdvInfos)
                    .HasForeignKey(d => d.Runid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_INFO_FK");
            });

            modelBuilder.Entity<MviewAdvJournal>(entity =>
            {
                entity.HasKey(e => new { e.Runid, e.Seq })
                    .HasName("MVIEW$_ADV_JOURNAL_PK");

                entity.ToTable("MVIEW$_ADV_JOURNAL");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.Property(e => e.Seq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ#");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Num)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUM");

                entity.Property(e => e.Text)
                    .HasColumnType("LONG")
                    .HasColumnName("TEXT");

                entity.Property(e => e.Textlen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEXTLEN");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("DATE")
                    .HasColumnName("TIMESTAMP");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.MviewAdvJournals)
                    .HasForeignKey(d => d.Runid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_JOURNAL_FK");
            });

            modelBuilder.Entity<MviewAdvLevel>(entity =>
            {
                entity.HasKey(e => new { e.Runid, e.Levelid })
                    .HasName("MVIEW$_ADV_LEVEL_PK");

                entity.ToTable("MVIEW$_ADV_LEVEL");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.Property(e => e.Levelid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LEVELID#");

                entity.Property(e => e.Columnlist)
                    .IsRequired()
                    .HasMaxLength(70)
                    .HasColumnName("COLUMNLIST");

                entity.Property(e => e.Dimobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DIMOBJ#");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Levelname)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("LEVELNAME");

                entity.Property(e => e.Tblobj)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TBLOBJ#");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.MviewAdvLevels)
                    .HasForeignKey(d => d.Runid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_LEVEL_FK");
            });

            modelBuilder.Entity<MviewAdvLog>(entity =>
            {
                entity.HasKey(e => e.Runid)
                    .HasName("MVIEW$_ADV_LOG_PK");

                entity.ToTable("MVIEW$_ADV_LOG");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.Property(e => e.Completed)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMPLETED");

                entity.Property(e => e.ErrorCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_CODE");

                entity.Property(e => e.Filterid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FILTERID#");

                entity.Property(e => e.Message)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.RunBegin)
                    .HasColumnType("DATE")
                    .HasColumnName("RUN_BEGIN");

                entity.Property(e => e.RunEnd)
                    .HasColumnType("DATE")
                    .HasColumnName("RUN_END");

                entity.Property(e => e.RunType)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUN_TYPE");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Total)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.Uname)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("UNAME");
            });

            modelBuilder.Entity<MviewAdvOutput>(entity =>
            {
                entity.HasKey(e => new { e.Runid, e.Rank })
                    .HasName("MVIEW$_ADV_OUTPUT_PK");

                entity.ToTable("MVIEW$_ADV_OUTPUT");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.Property(e => e.Rank)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RANK#");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_TYPE");

                entity.Property(e => e.BenefitToCostRatio)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BENEFIT_TO_COST_RATIO");

                entity.Property(e => e.CumulativeBenefit)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUMULATIVE_BENEFIT");

                entity.Property(e => e.FactTables)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("FACT_TABLES");

                entity.Property(e => e.Frequency)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.FromClause)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("FROM_CLAUSE");

                entity.Property(e => e.GroupByColumns)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("GROUP_BY_COLUMNS");

                entity.Property(e => e.GroupingLevels)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("GROUPING_LEVELS");

                entity.Property(e => e.MeasuresList)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MEASURES_LIST");

                entity.Property(e => e.OutputType)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OUTPUT_TYPE");

                entity.Property(e => e.PctPerformanceGain)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PCT_PERFORMANCE_GAIN");

                entity.Property(e => e.QueryText)
                    .HasColumnType("LONG")
                    .HasColumnName("QUERY_TEXT");

                entity.Property(e => e.Querylen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUERYLEN");

                entity.Property(e => e.StorageInBytes)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STORAGE_IN_BYTES");

                entity.Property(e => e.SummaryName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SUMMARY_NAME");

                entity.Property(e => e.SummaryOwner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SUMMARY_OWNER");

                entity.Property(e => e.Validated)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VALIDATED");

                entity.Property(e => e.WhereClause)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("WHERE_CLAUSE");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.MviewAdvOutputs)
                    .HasForeignKey(d => d.Runid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_OUTPUT_FK");
            });

            modelBuilder.Entity<MviewAdvParameter>(entity =>
            {
                entity.HasKey(e => e.ParameterName)
                    .HasName("MVIEW$_ADV_PARAMETERS_PK");

                entity.ToTable("MVIEW$_ADV_PARAMETERS");

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER_NAME");

                entity.Property(e => e.DateValue)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE");

                entity.Property(e => e.NumericalValue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMERICAL_VALUE");

                entity.Property(e => e.ParameterType)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARAMETER_TYPE");

                entity.Property(e => e.StringValue)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STRING_VALUE");
            });

            modelBuilder.Entity<MviewAdvPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MVIEW$_ADV_PLAN");

                entity.Property(e => e.Bytes)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BYTES");

                entity.Property(e => e.Cardinality)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CARDINALITY");

                entity.Property(e => e.Cost)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COST");

                entity.Property(e => e.CpuCost)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CPU_COST");

                entity.Property(e => e.Distribution)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DISTRIBUTION");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID");

                entity.Property(e => e.IoCost)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IO_COST");

                entity.Property(e => e.ObjectInstance)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_INSTANCE");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_NAME");

                entity.Property(e => e.ObjectNode)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_NODE");

                entity.Property(e => e.ObjectOwner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_OWNER");

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_TYPE");

                entity.Property(e => e.Operation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION");

                entity.Property(e => e.Optimizer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OPTIMIZER");

                entity.Property(e => e.Options)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OPTIONS");

                entity.Property(e => e.Other)
                    .HasColumnType("LONG")
                    .HasColumnName("OTHER");

                entity.Property(e => e.OtherTag)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_TAG");

                entity.Property(e => e.ParentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARENT_ID");

                entity.Property(e => e.PartitionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARTITION_ID");

                entity.Property(e => e.PartitionStart)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PARTITION_START");

                entity.Property(e => e.PartitionStop)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PARTITION_STOP");

                entity.Property(e => e.Position)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("POSITION");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.SearchColumns)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEARCH_COLUMNS");

                entity.Property(e => e.StatementId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STATEMENT_ID");

                entity.Property(e => e.TempSpace)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TEMP_SPACE");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("DATE")
                    .HasColumnName("TIMESTAMP");
            });

            modelBuilder.Entity<MviewAdvPretty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MVIEW$_ADV_PRETTY");

                entity.HasIndex(e => e.Queryid, "MVIEW$_ADV_PRETTY_IDX_01");

                entity.Property(e => e.Queryid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUERYID#");

                entity.Property(e => e.SqlText)
                    .HasColumnType("LONG")
                    .HasColumnName("SQL_TEXT");
            });

            modelBuilder.Entity<MviewAdvRollup>(entity =>
            {
                entity.HasKey(e => new { e.Runid, e.Clevelid, e.Plevelid })
                    .HasName("MVIEW$_ADV_ROLLUP_PK");

                entity.ToTable("MVIEW$_ADV_ROLLUP");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID#");

                entity.Property(e => e.Clevelid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CLEVELID#");

                entity.Property(e => e.Plevelid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PLEVELID#");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.MviewAdvRollups)
                    .HasForeignKey(d => d.Runid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_ROLLUP_FK");

                entity.HasOne(d => d.MviewAdvLevel)
                    .WithMany(p => p.MviewAdvRollupMviewAdvLevels)
                    .HasForeignKey(d => new { d.Runid, d.Clevelid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_ROLLUP_CFK");

                entity.HasOne(d => d.MviewAdvLevelNavigation)
                    .WithMany(p => p.MviewAdvRollupMviewAdvLevelNavigations)
                    .HasForeignKey(d => new { d.Runid, d.Plevelid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MVIEW$_ADV_ROLLUP_PFK");
            });

            modelBuilder.Entity<MviewAdvSqldepend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MVIEW$_ADV_SQLDEPEND");

                entity.HasIndex(e => new { e.Collectionid, e.FromAddress, e.FromHash, e.InstId }, "MVIEW$_ADV_SQLDEPEND_IDX_01");

                entity.Property(e => e.Cardinality)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CARDINALITY");

                entity.Property(e => e.Collectionid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLLECTIONID#");

                entity.Property(e => e.FromAddress).HasColumnName("FROM_ADDRESS");

                entity.Property(e => e.FromHash)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FROM_HASH");

                entity.Property(e => e.InstId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ID");

                entity.Property(e => e.ToName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TO_NAME");

                entity.Property(e => e.ToOwner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("TO_OWNER");

                entity.Property(e => e.ToType)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TO_TYPE");
            });

            modelBuilder.Entity<MviewAdvTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MVIEW$_ADV_TEMP");

                entity.HasIndex(e => new { e.Id, e.Seq }, "MVIEW$_ADV_TEMP_IDX_01");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID#");

                entity.Property(e => e.Seq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ#");

                entity.Property(e => e.Text)
                    .HasColumnType("LONG")
                    .HasColumnName("TEXT");
            });

            modelBuilder.Entity<MviewAdvWorkload>(entity =>
            {
                entity.HasKey(e => e.Queryid)
                    .HasName("MVIEW$_ADV_WORKLOAD_PK");

                entity.ToTable("MVIEW$_ADV_WORKLOAD");

                entity.HasIndex(e => new { e.Collectionid, e.Queryid }, "MVIEW$_ADV_WORKLOAD_IDX_01");

                entity.Property(e => e.Queryid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUERYID#");

                entity.Property(e => e.Application)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("APPLICATION");

                entity.Property(e => e.Cardinality)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CARDINALITY");

                entity.Property(e => e.Collectionid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COLLECTIONID#");

                entity.Property(e => e.Collecttime)
                    .HasColumnType("DATE")
                    .HasColumnName("COLLECTTIME");

                entity.Property(e => e.ExecTime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EXEC_TIME");

                entity.Property(e => e.Frequency)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.Priority)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIORITY");

                entity.Property(e => e.Qdate)
                    .HasColumnType("DATE")
                    .HasColumnName("QDATE");

                entity.Property(e => e.Resultsize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESULTSIZE");

                entity.Property(e => e.SqlAddr).HasColumnName("SQL_ADDR");

                entity.Property(e => e.SqlHash)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SQL_HASH");

                entity.Property(e => e.SqlText)
                    .IsRequired()
                    .HasColumnType("LONG")
                    .HasColumnName("SQL_TEXT");

                entity.Property(e => e.SqlTextlen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SQL_TEXTLEN");

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("UNAME");
            });

            modelBuilder.Entity<MviewEvaluation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MVIEW_EVALUATIONS");

                entity.Property(e => e.BenefitToCostRatio)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BENEFIT_TO_COST_RATIO");

                entity.Property(e => e.CumulativeBenefit)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUMULATIVE_BENEFIT");

                entity.Property(e => e.Frequency)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.MviewName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("MVIEW_NAME");

                entity.Property(e => e.MviewOwner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("MVIEW_OWNER");

                entity.Property(e => e.Rank)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RANK");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID");

                entity.Property(e => e.StorageInBytes)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STORAGE_IN_BYTES");
            });

            modelBuilder.Entity<MviewException>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MVIEW_EXCEPTIONS");

                entity.Property(e => e.BadRowid)
                    .HasColumnType("ROWID")
                    .HasColumnName("BAD_ROWID");

                entity.Property(e => e.DimensionName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("DIMENSION_NAME");

                entity.Property(e => e.Owner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Relationship)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONSHIP");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");
            });

            modelBuilder.Entity<MviewFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MVIEW_FILTER");

                entity.Property(e => e.DateValue1)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE1");

                entity.Property(e => e.DateValue2)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE2");

                entity.Property(e => e.Filterid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FILTERID");

                entity.Property(e => e.NumValue1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUM_VALUE1");

                entity.Property(e => e.NumValue2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUM_VALUE2");

                entity.Property(e => e.StrValue)
                    .HasMaxLength(1028)
                    .IsUnicode(false)
                    .HasColumnName("STR_VALUE");

                entity.Property(e => e.Subfilternum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBFILTERNUM");

                entity.Property(e => e.Subfiltertype)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SUBFILTERTYPE");
            });

            modelBuilder.Entity<MviewFilterinstance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MVIEW_FILTERINSTANCE");

                entity.Property(e => e.DateValue1)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE1");

                entity.Property(e => e.DateValue2)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE2");

                entity.Property(e => e.Filterid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FILTERID");

                entity.Property(e => e.NumValue1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUM_VALUE1");

                entity.Property(e => e.NumValue2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUM_VALUE2");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID");

                entity.Property(e => e.StrValue)
                    .HasMaxLength(1028)
                    .IsUnicode(false)
                    .HasColumnName("STR_VALUE");

                entity.Property(e => e.Subfilternum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBFILTERNUM");

                entity.Property(e => e.Subfiltertype)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SUBFILTERTYPE");
            });

            modelBuilder.Entity<MviewLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MVIEW_LOG");

                entity.Property(e => e.Completed)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMPLETED");

                entity.Property(e => e.ErrorCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_CODE");

                entity.Property(e => e.Filterid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FILTERID");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Message)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.RunBegin)
                    .HasColumnType("DATE")
                    .HasColumnName("RUN_BEGIN");

                entity.Property(e => e.RunEnd)
                    .HasColumnType("DATE")
                    .HasColumnName("RUN_END");

                entity.Property(e => e.Status)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Total)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.Type)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<MviewRecommendation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MVIEW_RECOMMENDATIONS");

                entity.Property(e => e.AllTables)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ALL_TABLES");

                entity.Property(e => e.BenefitToCostRatio)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BENEFIT_TO_COST_RATIO");

                entity.Property(e => e.FactTables)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("FACT_TABLES");

                entity.Property(e => e.GroupingLevels)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("GROUPING_LEVELS");

                entity.Property(e => e.MviewName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("MVIEW_NAME");

                entity.Property(e => e.MviewOwner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("MVIEW_OWNER");

                entity.Property(e => e.PctPerformanceGain)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PCT_PERFORMANCE_GAIN");

                entity.Property(e => e.QueryText)
                    .HasColumnType("LONG")
                    .HasColumnName("QUERY_TEXT");

                entity.Property(e => e.RecommendationNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RECOMMENDATION_NUMBER");

                entity.Property(e => e.RecommendedAction)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RECOMMENDED_ACTION");

                entity.Property(e => e.Runid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RUNID");

                entity.Property(e => e.StorageInBytes)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STORAGE_IN_BYTES");
            });

            modelBuilder.Entity<MviewWorkload>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MVIEW_WORKLOAD");

                entity.Property(e => e.Application)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("APPLICATION");

                entity.Property(e => e.Cardinality)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CARDINALITY");

                entity.Property(e => e.Frequency)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.ImportTime)
                    .HasColumnType("DATE")
                    .HasColumnName("IMPORT_TIME");

                entity.Property(e => e.Lastuse)
                    .HasColumnType("DATE")
                    .HasColumnName("LASTUSE");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Priority)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIORITY");

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasColumnType("LONG")
                    .HasColumnName("QUERY");

                entity.Property(e => e.Queryid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUERYID");

                entity.Property(e => e.Responsetime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESPONSETIME");

                entity.Property(e => e.Resultsize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESULTSIZE");

                entity.Property(e => e.Workloadid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WORKLOADID");
            });

            modelBuilder.Entity<Ol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OL$");

                entity.HasIndex(e => e.OlName, "OL$NAME")
                    .IsUnique();

                entity.HasIndex(e => new { e.Signature, e.Category }, "OL$SIGNATURE")
                    .IsUnique();

                entity.Property(e => e.Category)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Creator)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("CREATOR");

                entity.Property(e => e.Flags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FLAGS");

                entity.Property(e => e.HashValue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HASH_VALUE");

                entity.Property(e => e.HashValue2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HASH_VALUE2");

                entity.Property(e => e.Hintcount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HINTCOUNT");

                entity.Property(e => e.OlName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OL_NAME");

                entity.Property(e => e.Signature).HasColumnName("SIGNATURE");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SPARE2");

                entity.Property(e => e.SqlText)
                    .HasColumnType("LONG")
                    .HasColumnName("SQL_TEXT");

                entity.Property(e => e.Textlen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEXTLEN");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("DATE")
                    .HasColumnName("TIMESTAMP");

                entity.Property(e => e.Version)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<OlHint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OL$HINTS");

                entity.HasIndex(e => new { e.OlName, e.Hint }, "OL$HNT_NUM")
                    .IsUnique();

                entity.Property(e => e.Bytes)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BYTES");

                entity.Property(e => e.Cardinality)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CARDINALITY");

                entity.Property(e => e.Category)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Cost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("COST");

                entity.Property(e => e.Hint)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HINT#");

                entity.Property(e => e.HintString)
                    .HasColumnType("CLOB")
                    .HasColumnName("HINT_STRING");

                entity.Property(e => e.HintText)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("HINT_TEXT");

                entity.Property(e => e.HintTextlen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HINT_TEXTLEN");

                entity.Property(e => e.HintTextoff)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HINT_TEXTOFF");

                entity.Property(e => e.HintType)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HINT_TYPE");

                entity.Property(e => e.JoinPred)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("JOIN_PRED");

                entity.Property(e => e.Node)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NODE#");

                entity.Property(e => e.OlName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OL_NAME");

                entity.Property(e => e.RefId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REF_ID");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Stage)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STAGE#");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.TablePos)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TABLE_POS");

                entity.Property(e => e.TableTin)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TABLE_TIN");

                entity.Property(e => e.UserTableName)
                    .HasMaxLength(260)
                    .IsUnicode(false)
                    .HasColumnName("USER_TABLE_NAME");
            });

            modelBuilder.Entity<OlNode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OL$NODES");

                entity.Property(e => e.Category)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.NodeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NODE_ID");

                entity.Property(e => e.NodeName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("NODE_NAME");

                entity.Property(e => e.NodeTextlen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NODE_TEXTLEN");

                entity.Property(e => e.NodeTextoff)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NODE_TEXTOFF");

                entity.Property(e => e.NodeType)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NODE_TYPE");

                entity.Property(e => e.OlName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OL_NAME");

                entity.Property(e => e.ParentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARENT_ID");
            });

            modelBuilder.Entity<ProductPriv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PRODUCT_PRIVS");

                entity.Property(e => e.Attribute)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE");

                entity.Property(e => e.CharValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CHAR_VALUE");

                entity.Property(e => e.DateValue)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE");

                entity.Property(e => e.LongValue)
                    .HasColumnType("LONG")
                    .HasColumnName("LONG_VALUE");

                entity.Property(e => e.NumericValue)
                    .HasColumnType("NUMBER(15,2)")
                    .HasColumnName("NUMERIC_VALUE");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Scope)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("SCOPE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<RedoDb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REDO_DB");

                entity.HasIndex(e => new { e.Dbid, e.Thread, e.ResetlogsScn, e.ResetlogsTime }, "REDO_DB_IDX");

                entity.Property(e => e.ApplyDone)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPLY_DONE");

                entity.Property(e => e.ApplySeqno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPLY_SEQNO");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.Curblkno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CURBLKNO");

                entity.Property(e => e.Curlog)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CURLOG");

                entity.Property(e => e.CurscnTime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CURSCN_TIME");

                entity.Property(e => e.Dbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DBID");

                entity.Property(e => e.Dbuname)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("DBUNAME");

                entity.Property(e => e.Endian)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENDIAN");

                entity.Property(e => e.Enqidx)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENQIDX");

                entity.Property(e => e.Error1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ERROR1");

                entity.Property(e => e.GapDone)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GAP_DONE");

                entity.Property(e => e.GapNextScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GAP_NEXT_SCN");

                entity.Property(e => e.GapNextTime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GAP_NEXT_TIME");

                entity.Property(e => e.GapRet)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GAP_RET");

                entity.Property(e => e.GapRet2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GAP_RET2");

                entity.Property(e => e.GapSeqno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GAP_SEQNO");

                entity.Property(e => e.GlobalDbname)
                    .HasMaxLength(129)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_DBNAME");

                entity.Property(e => e.HasChild)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HAS_CHILD");

                entity.Property(e => e.PresetlogsScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRESETLOGS_SCN");

                entity.Property(e => e.PresetlogsScnBas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRESETLOGS_SCN_BAS");

                entity.Property(e => e.PresetlogsScnWrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRESETLOGS_SCN_WRP");

                entity.Property(e => e.PresetlogsTime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRESETLOGS_TIME");

                entity.Property(e => e.PurgeDone)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PURGE_DONE");

                entity.Property(e => e.ResetlogsScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESETLOGS_SCN");

                entity.Property(e => e.ResetlogsScnBas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESETLOGS_SCN_BAS");

                entity.Property(e => e.ResetlogsScnWrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESETLOGS_SCN_WRP");

                entity.Property(e => e.ResetlogsTime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESETLOGS_TIME");

                entity.Property(e => e.SeqnoDoneCur)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQNO_DONE_CUR");

                entity.Property(e => e.SeqnoDoneHi)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQNO_DONE_HI");

                entity.Property(e => e.SeqnoDoneLo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQNO_DONE_LO");

                entity.Property(e => e.SeqnoRcvCur)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQNO_RCV_CUR");

                entity.Property(e => e.SeqnoRcvHi)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQNO_RCV_HI");

                entity.Property(e => e.SeqnoRcvLo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQNO_RCV_LO");

                entity.Property(e => e.Spare10)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE10");

                entity.Property(e => e.Spare11)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE11");

                entity.Property(e => e.Spare12)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE12");

                entity.Property(e => e.Spare4)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .HasColumnType("DATE")
                    .HasColumnName("SPARE5");

                entity.Property(e => e.Spare6)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("SPARE6");

                entity.Property(e => e.Spare7)
                    .HasMaxLength(129)
                    .IsUnicode(false)
                    .HasColumnName("SPARE7");

                entity.Property(e => e.Spare8)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE8");

                entity.Property(e => e.Spare9)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE9");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Thread)
                    .HasColumnType("NUMBER")
                    .HasColumnName("THREAD#");

                entity.Property(e => e.Ts1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TS1");

                entity.Property(e => e.Ts2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TS2");

                entity.Property(e => e.Ts3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TS3");

                entity.Property(e => e.Version)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<RedoLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REDO_LOG");

                entity.HasIndex(e => new { e.Dbid, e.Thread, e.ResetlogsScn, e.ResetlogsTime }, "REDO_LOG_IDX");

                entity.Property(e => e.BlockSize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BLOCK_SIZE");

                entity.Property(e => e.Blocks)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BLOCKS");

                entity.Property(e => e.CloseTime)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CLOSE_TIME");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_TIME");

                entity.Property(e => e.Dbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DBID");

                entity.Property(e => e.Dbuname)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("DBUNAME");

                entity.Property(e => e.DoneTime)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("DONE_TIME");

                entity.Property(e => e.Dupid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DUPID");

                entity.Property(e => e.Endian)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENDIAN");

                entity.Property(e => e.Error1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ERROR1");

                entity.Property(e => e.Error2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ERROR2");

                entity.Property(e => e.Filename)
                    .HasMaxLength(513)
                    .IsUnicode(false)
                    .HasColumnName("FILENAME");

                entity.Property(e => e.FirstScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FIRST_SCN");

                entity.Property(e => e.FirstScnBas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FIRST_SCN_BAS");

                entity.Property(e => e.FirstScnWrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FIRST_SCN_WRP");

                entity.Property(e => e.FirstTime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FIRST_TIME");

                entity.Property(e => e.GlobalDbname)
                    .HasMaxLength(129)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_DBNAME");

                entity.Property(e => e.NextScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NEXT_SCN");

                entity.Property(e => e.NextScnBas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NEXT_SCN_BAS");

                entity.Property(e => e.NextScnWrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NEXT_SCN_WRP");

                entity.Property(e => e.NextTime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NEXT_TIME");

                entity.Property(e => e.OldBlocks)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OLD_BLOCKS");

                entity.Property(e => e.OldFilename)
                    .HasMaxLength(513)
                    .IsUnicode(false)
                    .HasColumnName("OLD_FILENAME");

                entity.Property(e => e.OldStatus1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OLD_STATUS1");

                entity.Property(e => e.OldStatus2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OLD_STATUS2");

                entity.Property(e => e.PresetlogsScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRESETLOGS_SCN");

                entity.Property(e => e.PresetlogsScnBas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRESETLOGS_SCN_BAS");

                entity.Property(e => e.PresetlogsScnWrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRESETLOGS_SCN_WRP");

                entity.Property(e => e.PresetlogsTime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRESETLOGS_TIME");

                entity.Property(e => e.ResetlogsScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESETLOGS_SCN");

                entity.Property(e => e.ResetlogsScnBas)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESETLOGS_SCN_BAS");

                entity.Property(e => e.ResetlogsScnWrp)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESETLOGS_SCN_WRP");

                entity.Property(e => e.ResetlogsTime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESETLOGS_TIME");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE#");

                entity.Property(e => e.Spare10)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE10");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Spare4)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE4");

                entity.Property(e => e.Spare5)
                    .HasColumnType("DATE")
                    .HasColumnName("SPARE5");

                entity.Property(e => e.Spare6)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("SPARE6");

                entity.Property(e => e.Spare7)
                    .HasMaxLength(129)
                    .IsUnicode(false)
                    .HasColumnName("SPARE7");

                entity.Property(e => e.Spare8)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE8");

                entity.Property(e => e.Spare9)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE9");

                entity.Property(e => e.Status1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS1");

                entity.Property(e => e.Status2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS2");

                entity.Property(e => e.Thread)
                    .HasColumnType("NUMBER")
                    .HasColumnName("THREAD#");

                entity.Property(e => e.Ts1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TS1");

                entity.Property(e => e.Ts2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TS2");

                entity.Property(e => e.Ts3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TS3");

                entity.Property(e => e.Version)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<RollingConnection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROLLING$CONNECTIONS");

                entity.Property(e => e.Attributes)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTRIBUTES");

                entity.Property(e => e.ConnHandle)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONN_HANDLE");

                entity.Property(e => e.ConnectTime)
                    .HasPrecision(6)
                    .HasColumnName("CONNECT_TIME");

                entity.Property(e => e.DestPid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEST_PID");

                entity.Property(e => e.DestRdbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEST_RDBID");

                entity.Property(e => e.DisconnectTime)
                    .HasPrecision(6)
                    .HasColumnName("DISCONNECT_TIME");

                entity.Property(e => e.SendTime)
                    .HasPrecision(6)
                    .HasColumnName("SEND_TIME");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE_NAME");

                entity.Property(e => e.SourcePid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SOURCE_PID");

                entity.Property(e => e.SourceRdbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SOURCE_RDBID");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.UpdateTime)
                    .HasPrecision(6)
                    .HasColumnName("UPDATE_TIME");
            });

            modelBuilder.Entity<RollingDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROLLING$DATABASES");

                entity.Property(e => e.Attributes)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTRIBUTES");

                entity.Property(e => e.Attributes2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTRIBUTES2");

                entity.Property(e => e.ConsRid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONS_RID");

                entity.Property(e => e.ConsRscn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONS_RSCN");

                entity.Property(e => e.ConsScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONS_SCN");

                entity.Property(e => e.Dbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DBID");

                entity.Property(e => e.Dbun)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("DBUN");

                entity.Property(e => e.EngineStatus)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENGINE_STATUS");

                entity.Property(e => e.ProdRid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROD_RID");

                entity.Property(e => e.ProdRscn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROD_RSCN");

                entity.Property(e => e.ProdScn)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROD_SCN");

                entity.Property(e => e.Rdbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RDBID");

                entity.Property(e => e.RedoSource)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REDO_SOURCE");

                entity.Property(e => e.Revision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REVISION");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.UpdateTime)
                    .HasPrecision(6)
                    .HasColumnName("UPDATE_TIME");

                entity.Property(e => e.Version)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<RollingDirective>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROLLING$DIRECTIVES");

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Directid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DIRECTID");

                entity.Property(e => e.Feature)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("FEATURE");

                entity.Property(e => e.Flags)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("FLAGS");

                entity.Property(e => e.Opcode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OPCODE");

                entity.Property(e => e.P1)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.P2)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.P3)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PHASE");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Target)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TARGET");

                entity.Property(e => e.Taskid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TASKID");
            });

            modelBuilder.Entity<RollingEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROLLING$EVENTS");

                entity.Property(e => e.EventTime)
                    .HasPrecision(6)
                    .HasColumnName("EVENT_TIME");

                entity.Property(e => e.Eventid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EVENTID");

                entity.Property(e => e.Instid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INSTID");

                entity.Property(e => e.Message)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Revision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REVISION");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Type)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<RollingParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROLLING$PARAMETERS");

                entity.Property(e => e.Attributes)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTRIBUTES");

                entity.Property(e => e.Curval)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("CURVAL");

                entity.Property(e => e.Datatype)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DATATYPE");

                entity.Property(e => e.Defval)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("DEFVAL");

                entity.Property(e => e.Descrip)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIP");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Lstval)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("LSTVAL");

                entity.Property(e => e.Maxval)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MAXVAL");

                entity.Property(e => e.Minval)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MINVAL");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Scope)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCOPE");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<RollingPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROLLING$PLAN");

                entity.Property(e => e.Batchid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BATCHID");

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Directid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DIRECTID");

                entity.Property(e => e.ExecInfo)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EXEC_INFO");

                entity.Property(e => e.ExecStatus)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EXEC_STATUS");

                entity.Property(e => e.ExecTime)
                    .HasPrecision(6)
                    .HasColumnName("EXEC_TIME");

                entity.Property(e => e.FinishTime)
                    .HasPrecision(6)
                    .HasColumnName("FINISH_TIME");

                entity.Property(e => e.Instid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INSTID");

                entity.Property(e => e.Opcode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OPCODE");

                entity.Property(e => e.P1)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.P2)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.P3)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.P4)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PHASE");

                entity.Property(e => e.PostStatus)
                    .HasColumnType("NUMBER")
                    .HasColumnName("POST_STATUS");

                entity.Property(e => e.Progress)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROGRESS");

                entity.Property(e => e.Revision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REVISION");

                entity.Property(e => e.Rflags)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RFLAGS");

                entity.Property(e => e.Source)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Target)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TARGET");

                entity.Property(e => e.Taskid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TASKID");
            });

            modelBuilder.Entity<RollingStatistic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROLLING$STATISTICS");

                entity.Property(e => e.Attributes)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTRIBUTES");

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Rdbid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RDBID");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.Statid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATID");

                entity.Property(e => e.Type)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TYPE");

                entity.Property(e => e.UpdateTime)
                    .HasPrecision(6)
                    .HasColumnName("UPDATE_TIME");

                entity.Property(e => e.Valueint)
                    .HasColumnType("INTERVAL DAY(3) TO SECOND(2)")
                    .HasColumnName("VALUEINT");

                entity.Property(e => e.Valuenum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VALUENUM");

                entity.Property(e => e.Valuestr)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("VALUESTR");

                entity.Property(e => e.Valuets)
                    .HasPrecision(6)
                    .HasColumnName("VALUETS");
            });

            modelBuilder.Entity<RollingStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROLLING$STATUS");

                entity.Property(e => e.Batchid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BATCHID");

                entity.Property(e => e.BuildTime)
                    .HasPrecision(6)
                    .HasColumnName("BUILD_TIME");

                entity.Property(e => e.Coordid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COORDID");

                entity.Property(e => e.Dbactive)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DBACTIVE");

                entity.Property(e => e.Dbtotal)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DBTOTAL");

                entity.Property(e => e.FinishTime)
                    .HasPrecision(6)
                    .HasColumnName("FINISH_TIME");

                entity.Property(e => e.Fprimary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FPRIMARY");

                entity.Property(e => e.InitTime)
                    .HasPrecision(6)
                    .HasColumnName("INIT_TIME");

                entity.Property(e => e.Instance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INSTANCE");

                entity.Property(e => e.LastBatchid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_BATCHID");

                entity.Property(e => e.LastInstid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_INSTID");

                entity.Property(e => e.Location)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Oprimary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OPRIMARY");

                entity.Property(e => e.Phase)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PHASE");

                entity.Property(e => e.Pid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PID");

                entity.Property(e => e.Revision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REVISION");

                entity.Property(e => e.Spare1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE1");

                entity.Property(e => e.Spare2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SPARE2");

                entity.Property(e => e.Spare3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SPARE3");

                entity.Property(e => e.StartTime)
                    .HasPrecision(6)
                    .HasColumnName("START_TIME");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUS");

                entity.Property(e => e.SwitchTime)
                    .HasPrecision(6)
                    .HasColumnName("SWITCH_TIME");
            });

            modelBuilder.Entity<SchedulerJobArg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SCHEDULER_JOB_ARGS");

                entity.Property(e => e.ArgumentName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ARGUMENT_NAME");

                entity.Property(e => e.ArgumentPosition)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARGUMENT_POSITION");

                entity.Property(e => e.ArgumentType)
                    .HasMaxLength(257)
                    .IsUnicode(false)
                    .HasColumnName("ARGUMENT_TYPE");

                entity.Property(e => e.JobName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("JOB_NAME");

                entity.Property(e => e.OutArgument)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OUT_ARGUMENT");

                entity.Property(e => e.Owner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Value)
                    .IsUnicode(false)
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<SchedulerJobArgsTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SCHEDULER_JOB_ARGS_TBL");

                entity.Property(e => e.ArgumentName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ARGUMENT_NAME");

                entity.Property(e => e.ArgumentPosition)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARGUMENT_POSITION");

                entity.Property(e => e.ArgumentType)
                    .HasMaxLength(257)
                    .IsUnicode(false)
                    .HasColumnName("ARGUMENT_TYPE");

                entity.Property(e => e.JobName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("JOB_NAME");

                entity.Property(e => e.OutArgument)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OUT_ARGUMENT");

                entity.Property(e => e.Owner)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Value)
                    .IsUnicode(false)
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<SchedulerProgramArg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SCHEDULER_PROGRAM_ARGS");

                entity.Property(e => e.ArgumentName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ARGUMENT_NAME");

                entity.Property(e => e.ArgumentPosition)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARGUMENT_POSITION");

                entity.Property(e => e.ArgumentType)
                    .HasMaxLength(257)
                    .IsUnicode(false)
                    .HasColumnName("ARGUMENT_TYPE");

                entity.Property(e => e.DefaultValue)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_VALUE");

                entity.Property(e => e.MetadataAttribute)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("METADATA_ATTRIBUTE");

                entity.Property(e => e.OutArgument)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OUT_ARGUMENT");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_NAME");
            });

            modelBuilder.Entity<SchedulerProgramArgsTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SCHEDULER_PROGRAM_ARGS_TBL");

                entity.Property(e => e.ArgumentName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ARGUMENT_NAME");

                entity.Property(e => e.ArgumentPosition)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARGUMENT_POSITION");

                entity.Property(e => e.ArgumentType)
                    .HasMaxLength(257)
                    .IsUnicode(false)
                    .HasColumnName("ARGUMENT_TYPE");

                entity.Property(e => e.DefaultValue)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_VALUE");

                entity.Property(e => e.MetadataAttribute)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("METADATA_ATTRIBUTE");

                entity.Property(e => e.OutArgument)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OUT_ARGUMENT");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_NAME");
            });

            modelBuilder.Entity<SqlplusProductProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SQLPLUS_PRODUCT_PROFILE");

                entity.Property(e => e.Attribute)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE");

                entity.Property(e => e.CharValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CHAR_VALUE");

                entity.Property(e => e.DateValue)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_VALUE");

                entity.Property(e => e.LongValue)
                    .HasColumnType("LONG")
                    .HasColumnName("LONG_VALUE");

                entity.Property(e => e.NumericValue)
                    .HasColumnType("NUMBER(15,2)")
                    .HasColumnName("NUMERIC_VALUE");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Scope)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("SCOPE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.HasSequence("LOGMNR_DIDS$");

            modelBuilder.HasSequence("LOGMNR_EVOLVE_SEQ$");

            modelBuilder.HasSequence("LOGMNR_SEQ$");

            modelBuilder.HasSequence("LOGMNR_UIDS$").IsCyclic();

            modelBuilder.HasSequence("MVIEW$_ADVSEQ_GENERIC");

            modelBuilder.HasSequence("MVIEW$_ADVSEQ_ID");

            modelBuilder.HasSequence("ROLLING_EVENT_SEQ$");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
