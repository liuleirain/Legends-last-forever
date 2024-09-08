namespace GameServer
{

  public partial class MainForm : global::System.Windows.Forms.Form
  {

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            主选项卡 = new System.Windows.Forms.TabControl();
            tabMain = new System.Windows.Forms.TabPage();
            重载数据 = new System.Windows.Forms.Button();
            清空命令日志 = new System.Windows.Forms.Button();
            对象统计 = new System.Windows.Forms.Label();
            MainTabs = new System.Windows.Forms.TabControl();
            tabSystem = new System.Windows.Forms.TabPage();
            系统日志 = new System.Windows.Forms.RichTextBox();
            tabChat = new System.Windows.Forms.TabPage();
            聊天日志 = new System.Windows.Forms.RichTextBox();
            tabCommands = new System.Windows.Forms.TabPage();
            命令日志 = new System.Windows.Forms.RichTextBox();
            tabPackets = new System.Windows.Forms.TabPage();
            rtbPacketsLogs = new System.Windows.Forms.RichTextBox();
            清空聊天日志 = new System.Windows.Forms.Button();
            保存聊天日志 = new System.Windows.Forms.Button();
            已经登录统计 = new System.Windows.Forms.Label();
            已经上线统计 = new System.Windows.Forms.Label();
            连接总数统计 = new System.Windows.Forms.Label();
            发送统计 = new System.Windows.Forms.Label();
            接收统计 = new System.Windows.Forms.Label();
            清空系统日志 = new System.Windows.Forms.Button();
            保存系统日志 = new System.Windows.Forms.Button();
            帧数统计 = new System.Windows.Forms.Label();
            tabCharacters = new System.Windows.Forms.TabPage();
            角色详情选项卡 = new System.Windows.Forms.TabControl();
            CharacterData_技能 = new System.Windows.Forms.TabPage();
            技能浏览表 = new System.Windows.Forms.DataGridView();
            CharacterData_装备 = new System.Windows.Forms.TabPage();
            装备浏览表 = new System.Windows.Forms.DataGridView();
            CharacterData_背包 = new System.Windows.Forms.TabPage();
            背包浏览表 = new System.Windows.Forms.DataGridView();
            CharacterData_仓库 = new System.Windows.Forms.TabPage();
            仓库浏览表 = new System.Windows.Forms.DataGridView();
            dgvCharacters = new System.Windows.Forms.DataGridView();
            角色右键菜单 = new System.Windows.Forms.ContextMenuStrip(components);
            右键菜单_复制CharName = new System.Windows.Forms.ToolStripMenuItem();
            右键菜单_复制Account = new System.Windows.Forms.ToolStripMenuItem();
            右键菜单_复制网络地址 = new System.Windows.Forms.ToolStripMenuItem();
            右键菜单_复制物理地址 = new System.Windows.Forms.ToolStripMenuItem();
            tabMaps = new System.Windows.Forms.TabPage();
            dgvMaps = new System.Windows.Forms.DataGridView();
            tabMonsters = new System.Windows.Forms.TabPage();
            掉落浏览表 = new System.Windows.Forms.DataGridView();
            怪物浏览表 = new System.Windows.Forms.DataGridView();
            tabBans = new System.Windows.Forms.TabPage();
            封禁浏览表 = new System.Windows.Forms.DataGridView();
            tabAnnouncements = new System.Windows.Forms.TabPage();
            开始公告按钮 = new System.Windows.Forms.Button();
            停止公告按钮 = new System.Windows.Forms.Button();
            删除公告按钮 = new System.Windows.Forms.Button();
            添加公告按钮 = new System.Windows.Forms.Button();
            公告浏览表 = new System.Windows.Forms.DataGridView();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RemainingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabConfig = new System.Windows.Forms.TabPage();
            S_软件授权分组 = new System.Windows.Forms.GroupBox();
            S_软件注册代码 = new System.Windows.Forms.TextBox();
            S_GameData分组 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            S_注意事项标签8 = new System.Windows.Forms.Label();
            S_注意事项标签7 = new System.Windows.Forms.Label();
            S_注意事项标签6 = new System.Windows.Forms.Label();
            S_注意事项标签5 = new System.Windows.Forms.Label();
            S_注意事项标签4 = new System.Windows.Forms.Label();
            S_注意事项标签3 = new System.Windows.Forms.Label();
            S_注意事项标签2 = new System.Windows.Forms.Label();
            S_注意事项标签1 = new System.Windows.Forms.Label();
            S_重载客户数据 = new System.Windows.Forms.Button();
            S_重载SystemData = new System.Windows.Forms.Button();
            S_浏览合并目录 = new System.Windows.Forms.Button();
            S_浏览备份目录 = new System.Windows.Forms.Button();
            S_浏览数据目录 = new System.Windows.Forms.Button();
            S_合并客户数据 = new System.Windows.Forms.Button();
            S_合并数据目录 = new System.Windows.Forms.TextBox();
            S_合并目录标签 = new System.Windows.Forms.Label();
            S_数据备份目录 = new System.Windows.Forms.TextBox();
            S_GameData目录 = new System.Windows.Forms.TextBox();
            S_备份目录标签 = new System.Windows.Forms.Label();
            S_数据目录标签 = new System.Windows.Forms.Label();
            S_游戏设置分组 = new System.Windows.Forms.GroupBox();
            L_NoobLevel = new System.Windows.Forms.Label();
            S_NoobLevel = new System.Windows.Forms.NumericUpDown();
            S_物品归属标签 = new System.Windows.Forms.Label();
            S_ItemOwnershipTime = new System.Windows.Forms.NumericUpDown();
            S_收益衰减标签 = new System.Windows.Forms.Label();
            S_物品清理标签 = new System.Windows.Forms.Label();
            S_ItemCleaningTime = new System.Windows.Forms.NumericUpDown();
            S_诱惑时长标签 = new System.Windows.Forms.Label();
            S_TemptationTime = new System.Windows.Forms.NumericUpDown();
            S_LessExpGradeRate = new System.Windows.Forms.NumericUpDown();
            S_收益等级标签 = new System.Windows.Forms.Label();
            S_LessExpGrade = new System.Windows.Forms.NumericUpDown();
            S_经验倍率标签 = new System.Windows.Forms.Label();
            S_ExpRate = new System.Windows.Forms.NumericUpDown();
            S_特修折扣标签 = new System.Windows.Forms.Label();
            S_EquipRepairDto = new System.Windows.Forms.NumericUpDown();
            S_怪物爆率标签 = new System.Windows.Forms.Label();
            S_ExtraDropRate = new System.Windows.Forms.NumericUpDown();
            S_OpenLevelCommand标签 = new System.Windows.Forms.Label();
            S_MaxLevel = new System.Windows.Forms.NumericUpDown();
            S_网络设置分组 = new System.Windows.Forms.GroupBox();
            S_掉线判定标签 = new System.Windows.Forms.Label();
            S_DisconnectTime = new System.Windows.Forms.NumericUpDown();
            S_限定封包标签 = new System.Windows.Forms.Label();
            S_PacketLimit = new System.Windows.Forms.NumericUpDown();
            L_AbnormalBlockTime = new System.Windows.Forms.Label();
            S_AbnormalBlockTime = new System.Windows.Forms.NumericUpDown();
            S_接收端口标签 = new System.Windows.Forms.Label();
            S_TSPort = new System.Windows.Forms.NumericUpDown();
            S_监听端口标签 = new System.Windows.Forms.Label();
            S_GSPort = new System.Windows.Forms.NumericUpDown();
            界面定时更新 = new System.Windows.Forms.Timer(components);
            下方控件页 = new System.Windows.Forms.Panel();
            保存按钮 = new System.Windows.Forms.Button();
            GMCommand文本 = new System.Windows.Forms.TextBox();
            GMCommand标签 = new System.Windows.Forms.Label();
            启动按钮 = new System.Windows.Forms.Button();
            停止按钮 = new System.Windows.Forms.Button();
            保存数据提醒 = new System.Windows.Forms.Timer(components);
            定时发送公告 = new System.Windows.Forms.Timer(components);
            主选项卡.SuspendLayout();
            tabMain.SuspendLayout();
            MainTabs.SuspendLayout();
            tabSystem.SuspendLayout();
            tabChat.SuspendLayout();
            tabCommands.SuspendLayout();
            tabPackets.SuspendLayout();
            tabCharacters.SuspendLayout();
            角色详情选项卡.SuspendLayout();
            CharacterData_技能.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)技能浏览表).BeginInit();
            CharacterData_装备.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)装备浏览表).BeginInit();
            CharacterData_背包.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)背包浏览表).BeginInit();
            CharacterData_仓库.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)仓库浏览表).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).BeginInit();
            角色右键菜单.SuspendLayout();
            tabMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaps).BeginInit();
            tabMonsters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)掉落浏览表).BeginInit();
            ((System.ComponentModel.ISupportInitialize)怪物浏览表).BeginInit();
            tabBans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)封禁浏览表).BeginInit();
            tabAnnouncements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)公告浏览表).BeginInit();
            tabConfig.SuspendLayout();
            S_软件授权分组.SuspendLayout();
            S_GameData分组.SuspendLayout();
            S_游戏设置分组.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)S_NoobLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_ItemOwnershipTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_ItemCleaningTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_TemptationTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_LessExpGradeRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_LessExpGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_ExpRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_EquipRepairDto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_ExtraDropRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_MaxLevel).BeginInit();
            S_网络设置分组.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)S_DisconnectTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_PacketLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_AbnormalBlockTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_TSPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_GSPort).BeginInit();
            下方控件页.SuspendLayout();
            SuspendLayout();
            // 
            // 主选项卡
            // 
            主选项卡.AllowDrop = true;
            主选项卡.Controls.Add(tabMain);
            主选项卡.Controls.Add(tabCharacters);
            主选项卡.Controls.Add(tabMaps);
            主选项卡.Controls.Add(tabMonsters);
            主选项卡.Controls.Add(tabBans);
            主选项卡.Controls.Add(tabAnnouncements);
            主选项卡.Controls.Add(tabConfig);
            主选项卡.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            主选项卡.ItemSize = new System.Drawing.Size(170, 30);
            主选项卡.Location = new System.Drawing.Point(4, 5);
            主选项卡.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            主选项卡.Name = "主选项卡";
            主选项卡.SelectedIndex = 0;
            主选项卡.Size = new System.Drawing.Size(1741, 855);
            主选项卡.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            主选项卡.TabIndex = 5;
            主选项卡.TabStop = false;
            // 
            // tabMain
            // 
            tabMain.BackColor = System.Drawing.Color.Gainsboro;
            tabMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tabMain.Controls.Add(重载数据);
            tabMain.Controls.Add(清空命令日志);
            tabMain.Controls.Add(对象统计);
            tabMain.Controls.Add(MainTabs);
            tabMain.Controls.Add(清空聊天日志);
            tabMain.Controls.Add(保存聊天日志);
            tabMain.Controls.Add(已经登录统计);
            tabMain.Controls.Add(已经上线统计);
            tabMain.Controls.Add(连接总数统计);
            tabMain.Controls.Add(发送统计);
            tabMain.Controls.Add(接收统计);
            tabMain.Controls.Add(清空系统日志);
            tabMain.Controls.Add(保存系统日志);
            tabMain.Controls.Add(帧数统计);
            tabMain.Location = new System.Drawing.Point(4, 34);
            tabMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabMain.Name = "tabMain";
            tabMain.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabMain.Size = new System.Drawing.Size(1733, 817);
            tabMain.TabIndex = 0;
            tabMain.Text = "Main";
            // 
            // 重载数据
            // 
            重载数据.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            重载数据.Enabled = false;
            重载数据.Location = new System.Drawing.Point(1068, 411);
            重载数据.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            重载数据.Name = "重载数据";
            重载数据.Size = new System.Drawing.Size(301, 57);
            重载数据.TabIndex = 15;
            重载数据.Text = "Reload Data";
            重载数据.UseVisualStyleBackColor = false;
            重载数据.Click += 重载数据_Click;
            // 
            // 清空命令日志
            // 
            清空命令日志.BackColor = System.Drawing.SystemColors.ActiveCaption;
            清空命令日志.Enabled = false;
            清空命令日志.Location = new System.Drawing.Point(1068, 558);
            清空命令日志.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            清空命令日志.Name = "清空命令日志";
            清空命令日志.Size = new System.Drawing.Size(301, 57);
            清空命令日志.TabIndex = 18;
            清空命令日志.Text = "Clear commands log";
            清空命令日志.UseVisualStyleBackColor = false;
            清空命令日志.Click += 清空命令日志_Click;
            // 
            // 对象统计
            // 
            对象统计.AutoSize = true;
            对象统计.ForeColor = System.Drawing.Color.Blue;
            对象统计.Location = new System.Drawing.Point(1068, 219);
            对象统计.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            对象统计.Name = "对象统计";
            对象统计.Size = new System.Drawing.Size(128, 16);
            对象统计.TabIndex = 17;
            对象统计.Text = "Objects statistics";
            // 
            // MainTabs
            // 
            MainTabs.Controls.Add(tabSystem);
            MainTabs.Controls.Add(tabChat);
            MainTabs.Controls.Add(tabCommands);
            MainTabs.Controls.Add(tabPackets);
            MainTabs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MainTabs.ItemSize = new System.Drawing.Size(230, 20);
            MainTabs.Location = new System.Drawing.Point(3, 3);
            MainTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MainTabs.Name = "MainTabs";
            MainTabs.SelectedIndex = 0;
            MainTabs.Size = new System.Drawing.Size(1033, 621);
            MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            MainTabs.TabIndex = 16;
            // 
            // tabSystem
            // 
            tabSystem.BackColor = System.Drawing.Color.Gainsboro;
            tabSystem.Controls.Add(系统日志);
            tabSystem.Location = new System.Drawing.Point(4, 24);
            tabSystem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabSystem.Name = "tabSystem";
            tabSystem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabSystem.Size = new System.Drawing.Size(1025, 593);
            tabSystem.TabIndex = 0;
            tabSystem.Text = "System logs";
            // 
            // 系统日志
            // 
            系统日志.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            系统日志.Dock = System.Windows.Forms.DockStyle.Fill;
            系统日志.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            系统日志.Location = new System.Drawing.Point(4, 5);
            系统日志.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            系统日志.Name = "系统日志";
            系统日志.ReadOnly = true;
            系统日志.Size = new System.Drawing.Size(1017, 583);
            系统日志.TabIndex = 0;
            系统日志.Text = "";
            // 
            // tabChat
            // 
            tabChat.BackColor = System.Drawing.Color.Gainsboro;
            tabChat.Controls.Add(聊天日志);
            tabChat.Location = new System.Drawing.Point(4, 24);
            tabChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabChat.Name = "tabChat";
            tabChat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabChat.Size = new System.Drawing.Size(1025, 593);
            tabChat.TabIndex = 1;
            tabChat.Text = "Chat Logs";
            // 
            // 聊天日志
            // 
            聊天日志.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            聊天日志.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            聊天日志.Location = new System.Drawing.Point(0, 0);
            聊天日志.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            聊天日志.Name = "聊天日志";
            聊天日志.ReadOnly = true;
            聊天日志.Size = new System.Drawing.Size(1020, 573);
            聊天日志.TabIndex = 1;
            聊天日志.Text = "";
            // 
            // tabCommands
            // 
            tabCommands.BackColor = System.Drawing.Color.Gainsboro;
            tabCommands.Controls.Add(命令日志);
            tabCommands.Location = new System.Drawing.Point(4, 24);
            tabCommands.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabCommands.Name = "tabCommands";
            tabCommands.Size = new System.Drawing.Size(1025, 593);
            tabCommands.TabIndex = 2;
            tabCommands.Text = "Commands logs";
            // 
            // 命令日志
            // 
            命令日志.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            命令日志.Dock = System.Windows.Forms.DockStyle.Fill;
            命令日志.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            命令日志.Location = new System.Drawing.Point(0, 0);
            命令日志.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            命令日志.Name = "命令日志";
            命令日志.ReadOnly = true;
            命令日志.Size = new System.Drawing.Size(1025, 593);
            命令日志.TabIndex = 2;
            命令日志.Text = "";
            // 
            // tabPackets
            // 
            tabPackets.Controls.Add(rtbPacketsLogs);
            tabPackets.Location = new System.Drawing.Point(4, 24);
            tabPackets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPackets.Name = "tabPackets";
            tabPackets.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPackets.Size = new System.Drawing.Size(1025, 593);
            tabPackets.TabIndex = 3;
            tabPackets.Text = "Packets";
            tabPackets.UseVisualStyleBackColor = true;
            // 
            // rtbPacketsLogs
            // 
            rtbPacketsLogs.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            rtbPacketsLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            rtbPacketsLogs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rtbPacketsLogs.Location = new System.Drawing.Point(3, 2);
            rtbPacketsLogs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rtbPacketsLogs.Name = "rtbPacketsLogs";
            rtbPacketsLogs.ReadOnly = true;
            rtbPacketsLogs.Size = new System.Drawing.Size(1019, 589);
            rtbPacketsLogs.TabIndex = 2;
            rtbPacketsLogs.Text = "";
            // 
            // 清空聊天日志
            // 
            清空聊天日志.BackColor = System.Drawing.SystemColors.ActiveCaption;
            清空聊天日志.Enabled = false;
            清空聊天日志.Location = new System.Drawing.Point(1068, 485);
            清空聊天日志.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            清空聊天日志.Name = "清空聊天日志";
            清空聊天日志.Size = new System.Drawing.Size(301, 57);
            清空聊天日志.TabIndex = 15;
            清空聊天日志.Text = "Empty chat logs";
            清空聊天日志.UseVisualStyleBackColor = false;
            清空聊天日志.Click += 清空聊天日志_Click;
            // 
            // 保存聊天日志
            // 
            保存聊天日志.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            保存聊天日志.Enabled = false;
            保存聊天日志.Location = new System.Drawing.Point(1068, 337);
            保存聊天日志.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            保存聊天日志.Name = "保存聊天日志";
            保存聊天日志.Size = new System.Drawing.Size(301, 57);
            保存聊天日志.TabIndex = 14;
            保存聊天日志.Text = "Save chat logs";
            保存聊天日志.UseVisualStyleBackColor = false;
            保存聊天日志.Click += 保存聊天日志_Click;
            // 
            // 已经登录统计
            // 
            已经登录统计.AutoSize = true;
            已经登录统计.ForeColor = System.Drawing.Color.Blue;
            已经登录统计.Location = new System.Drawing.Point(1068, 63);
            已经登录统计.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            已经登录统计.Name = "已经登录统计";
            已经登录统计.Size = new System.Drawing.Size(116, 16);
            已经登录统计.TabIndex = 13;
            已经登录统计.Text = "Already logged:";
            // 
            // 已经上线统计
            // 
            已经上线统计.AutoSize = true;
            已经上线统计.ForeColor = System.Drawing.Color.Blue;
            已经上线统计.Location = new System.Drawing.Point(1068, 94);
            已经上线统计.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            已经上线统计.Name = "已经上线统计";
            已经上线统计.Size = new System.Drawing.Size(89, 16);
            已经上线统计.TabIndex = 12;
            已经上线统计.Text = "Now online:";
            // 
            // 连接总数统计
            // 
            连接总数统计.AutoSize = true;
            连接总数统计.ForeColor = System.Drawing.Color.Blue;
            连接总数统计.Location = new System.Drawing.Point(1068, 32);
            连接总数统计.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            连接总数统计.Name = "连接总数统计";
            连接总数统计.Size = new System.Drawing.Size(135, 16);
            连接总数统计.TabIndex = 11;
            连接总数统计.Text = "Total connections:";
            // 
            // 发送统计
            // 
            发送统计.AutoSize = true;
            发送统计.ForeColor = System.Drawing.Color.Blue;
            发送统计.Location = new System.Drawing.Point(1068, 188);
            发送统计.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            发送统计.Name = "发送统计";
            发送统计.Size = new System.Drawing.Size(77, 16);
            发送统计.TabIndex = 10;
            发送统计.Text = "Data sent:";
            // 
            // 接收统计
            // 
            接收统计.AutoSize = true;
            接收统计.ForeColor = System.Drawing.Color.Blue;
            接收统计.Location = new System.Drawing.Point(1068, 156);
            接收统计.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            接收统计.Name = "接收统计";
            接收统计.Size = new System.Drawing.Size(77, 16);
            接收统计.TabIndex = 9;
            接收统计.Text = "Accepted:";
            // 
            // 清空系统日志
            // 
            清空系统日志.BackColor = System.Drawing.SystemColors.ActiveCaption;
            清空系统日志.Enabled = false;
            清空系统日志.Location = new System.Drawing.Point(1068, 411);
            清空系统日志.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            清空系统日志.Name = "清空系统日志";
            清空系统日志.Size = new System.Drawing.Size(301, 57);
            清空系统日志.TabIndex = 8;
            清空系统日志.Text = "Empty the system logs";
            清空系统日志.UseVisualStyleBackColor = false;
            清空系统日志.Visible = false;
            清空系统日志.Click += 清空系统日志_Click;
            // 
            // 保存系统日志
            // 
            保存系统日志.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            保存系统日志.Enabled = false;
            保存系统日志.Location = new System.Drawing.Point(1068, 263);
            保存系统日志.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            保存系统日志.Name = "保存系统日志";
            保存系统日志.Size = new System.Drawing.Size(301, 57);
            保存系统日志.TabIndex = 7;
            保存系统日志.Text = "Save system logs";
            保存系统日志.UseVisualStyleBackColor = false;
            保存系统日志.Click += 保存系统日志_Click;
            // 
            // 帧数统计
            // 
            帧数统计.AutoSize = true;
            帧数统计.ForeColor = System.Drawing.Color.Blue;
            帧数统计.Location = new System.Drawing.Point(1068, 126);
            帧数统计.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            帧数统计.Name = "帧数统计";
            帧数统计.Size = new System.Drawing.Size(91, 16);
            帧数统计.TabIndex = 1;
            帧数统计.Text = "Framerates:";
            // 
            // tabCharacters
            // 
            tabCharacters.BackColor = System.Drawing.Color.Gainsboro;
            tabCharacters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tabCharacters.Controls.Add(角色详情选项卡);
            tabCharacters.Controls.Add(dgvCharacters);
            tabCharacters.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabCharacters.Location = new System.Drawing.Point(4, 34);
            tabCharacters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabCharacters.Name = "tabCharacters";
            tabCharacters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabCharacters.Size = new System.Drawing.Size(1733, 817);
            tabCharacters.TabIndex = 4;
            tabCharacters.Text = "Characters";
            // 
            // 角色详情选项卡
            // 
            角色详情选项卡.Controls.Add(CharacterData_技能);
            角色详情选项卡.Controls.Add(CharacterData_装备);
            角色详情选项卡.Controls.Add(CharacterData_背包);
            角色详情选项卡.Controls.Add(CharacterData_仓库);
            角色详情选项卡.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            角色详情选项卡.ItemSize = new System.Drawing.Size(85, 20);
            角色详情选项卡.Location = new System.Drawing.Point(981, 5);
            角色详情选项卡.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            角色详情选项卡.Name = "角色详情选项卡";
            角色详情选项卡.SelectedIndex = 0;
            角色详情选项卡.Size = new System.Drawing.Size(402, 615);
            角色详情选项卡.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            角色详情选项卡.TabIndex = 2;
            // 
            // CharacterData_技能
            // 
            CharacterData_技能.BackColor = System.Drawing.Color.Gainsboro;
            CharacterData_技能.Controls.Add(技能浏览表);
            CharacterData_技能.Location = new System.Drawing.Point(4, 24);
            CharacterData_技能.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            CharacterData_技能.Name = "CharacterData_技能";
            CharacterData_技能.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            CharacterData_技能.Size = new System.Drawing.Size(394, 587);
            CharacterData_技能.TabIndex = 0;
            CharacterData_技能.Text = "Skills";
            // 
            // 技能浏览表
            // 
            技能浏览表.AllowUserToAddRows = false;
            技能浏览表.AllowUserToDeleteRows = false;
            技能浏览表.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            技能浏览表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            技能浏览表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            技能浏览表.BackgroundColor = System.Drawing.Color.LightGray;
            技能浏览表.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            技能浏览表.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            技能浏览表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            技能浏览表.ColumnHeadersHeight = 29;
            技能浏览表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            技能浏览表.DefaultCellStyle = dataGridViewCellStyle3;
            技能浏览表.GridColor = System.Drawing.SystemColors.ActiveCaption;
            技能浏览表.Location = new System.Drawing.Point(0, 0);
            技能浏览表.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            技能浏览表.MultiSelect = false;
            技能浏览表.Name = "技能浏览表";
            技能浏览表.ReadOnly = true;
            技能浏览表.RowHeadersVisible = false;
            技能浏览表.RowHeadersWidth = 51;
            技能浏览表.RowTemplate.Height = 23;
            技能浏览表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            技能浏览表.ShowCellToolTips = false;
            技能浏览表.Size = new System.Drawing.Size(386, 570);
            技能浏览表.TabIndex = 3;
            // 
            // CharacterData_装备
            // 
            CharacterData_装备.BackColor = System.Drawing.Color.Gainsboro;
            CharacterData_装备.Controls.Add(装备浏览表);
            CharacterData_装备.Location = new System.Drawing.Point(4, 24);
            CharacterData_装备.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            CharacterData_装备.Name = "CharacterData_装备";
            CharacterData_装备.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            CharacterData_装备.Size = new System.Drawing.Size(394, 587);
            CharacterData_装备.TabIndex = 1;
            CharacterData_装备.Text = "Equipment";
            // 
            // 装备浏览表
            // 
            装备浏览表.AllowUserToAddRows = false;
            装备浏览表.AllowUserToDeleteRows = false;
            装备浏览表.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            装备浏览表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            装备浏览表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            装备浏览表.BackgroundColor = System.Drawing.Color.LightGray;
            装备浏览表.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            装备浏览表.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            装备浏览表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            装备浏览表.ColumnHeadersHeight = 29;
            装备浏览表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            装备浏览表.DefaultCellStyle = dataGridViewCellStyle6;
            装备浏览表.GridColor = System.Drawing.SystemColors.ActiveCaption;
            装备浏览表.Location = new System.Drawing.Point(0, 0);
            装备浏览表.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            装备浏览表.MultiSelect = false;
            装备浏览表.Name = "装备浏览表";
            装备浏览表.ReadOnly = true;
            装备浏览表.RowHeadersVisible = false;
            装备浏览表.RowHeadersWidth = 51;
            装备浏览表.RowTemplate.Height = 23;
            装备浏览表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            装备浏览表.ShowCellToolTips = false;
            装备浏览表.Size = new System.Drawing.Size(386, 570);
            装备浏览表.TabIndex = 4;
            // 
            // CharacterData_背包
            // 
            CharacterData_背包.BackColor = System.Drawing.Color.Gainsboro;
            CharacterData_背包.Controls.Add(背包浏览表);
            CharacterData_背包.Location = new System.Drawing.Point(4, 24);
            CharacterData_背包.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            CharacterData_背包.Name = "CharacterData_背包";
            CharacterData_背包.Size = new System.Drawing.Size(394, 587);
            CharacterData_背包.TabIndex = 2;
            CharacterData_背包.Text = "Bag";
            // 
            // 背包浏览表
            // 
            背包浏览表.AllowUserToAddRows = false;
            背包浏览表.AllowUserToDeleteRows = false;
            背包浏览表.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            背包浏览表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            背包浏览表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            背包浏览表.BackgroundColor = System.Drawing.Color.LightGray;
            背包浏览表.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            背包浏览表.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            背包浏览表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            背包浏览表.ColumnHeadersHeight = 29;
            背包浏览表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            背包浏览表.DefaultCellStyle = dataGridViewCellStyle9;
            背包浏览表.GridColor = System.Drawing.SystemColors.ActiveCaption;
            背包浏览表.Location = new System.Drawing.Point(0, 0);
            背包浏览表.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            背包浏览表.MultiSelect = false;
            背包浏览表.Name = "背包浏览表";
            背包浏览表.ReadOnly = true;
            背包浏览表.RowHeadersVisible = false;
            背包浏览表.RowHeadersWidth = 51;
            背包浏览表.RowTemplate.Height = 23;
            背包浏览表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            背包浏览表.ShowCellToolTips = false;
            背包浏览表.Size = new System.Drawing.Size(386, 570);
            背包浏览表.TabIndex = 4;
            // 
            // CharacterData_仓库
            // 
            CharacterData_仓库.BackColor = System.Drawing.Color.Gainsboro;
            CharacterData_仓库.Controls.Add(仓库浏览表);
            CharacterData_仓库.Location = new System.Drawing.Point(4, 24);
            CharacterData_仓库.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            CharacterData_仓库.Name = "CharacterData_仓库";
            CharacterData_仓库.Size = new System.Drawing.Size(394, 587);
            CharacterData_仓库.TabIndex = 3;
            CharacterData_仓库.Text = "Store";
            // 
            // 仓库浏览表
            // 
            仓库浏览表.AllowUserToAddRows = false;
            仓库浏览表.AllowUserToDeleteRows = false;
            仓库浏览表.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            仓库浏览表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            仓库浏览表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            仓库浏览表.BackgroundColor = System.Drawing.Color.LightGray;
            仓库浏览表.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            仓库浏览表.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            仓库浏览表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            仓库浏览表.ColumnHeadersHeight = 29;
            仓库浏览表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            仓库浏览表.DefaultCellStyle = dataGridViewCellStyle12;
            仓库浏览表.GridColor = System.Drawing.SystemColors.ActiveCaption;
            仓库浏览表.Location = new System.Drawing.Point(0, 0);
            仓库浏览表.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            仓库浏览表.MultiSelect = false;
            仓库浏览表.Name = "仓库浏览表";
            仓库浏览表.ReadOnly = true;
            仓库浏览表.RowHeadersVisible = false;
            仓库浏览表.RowHeadersWidth = 51;
            仓库浏览表.RowTemplate.Height = 23;
            仓库浏览表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            仓库浏览表.ShowCellToolTips = false;
            仓库浏览表.Size = new System.Drawing.Size(386, 570);
            仓库浏览表.TabIndex = 5;
            // 
            // dgvCharacters
            // 
            dgvCharacters.AllowUserToAddRows = false;
            dgvCharacters.AllowUserToDeleteRows = false;
            dgvCharacters.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dgvCharacters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvCharacters.BackgroundColor = System.Drawing.Color.LightGray;
            dgvCharacters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvCharacters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCharacters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvCharacters.ColumnHeadersHeight = 29;
            dgvCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCharacters.ContextMenuStrip = 角色右键菜单;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCharacters.DefaultCellStyle = dataGridViewCellStyle15;
            dgvCharacters.GridColor = System.Drawing.SystemColors.ActiveCaption;
            dgvCharacters.Location = new System.Drawing.Point(0, 5);
            dgvCharacters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgvCharacters.MultiSelect = false;
            dgvCharacters.Name = "dgvCharacters";
            dgvCharacters.ReadOnly = true;
            dgvCharacters.RowHeadersVisible = false;
            dgvCharacters.RowHeadersWidth = 51;
            dgvCharacters.RowTemplate.Height = 23;
            dgvCharacters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCharacters.ShowCellToolTips = false;
            dgvCharacters.Size = new System.Drawing.Size(979, 615);
            dgvCharacters.TabIndex = 1;
            // 
            // 角色右键菜单
            // 
            角色右键菜单.ImageScalingSize = new System.Drawing.Size(20, 20);
            角色右键菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 右键菜单_复制CharName, 右键菜单_复制Account, 右键菜单_复制网络地址, 右键菜单_复制物理地址 });
            角色右键菜单.Name = "角色右键菜单";
            角色右键菜单.Size = new System.Drawing.Size(192, 92);
            // 
            // 右键菜单_复制CharName
            // 
            右键菜单_复制CharName.Name = "右键菜单_复制CharName";
            右键菜单_复制CharName.Size = new System.Drawing.Size(191, 22);
            右键菜单_复制CharName.Text = "Copy char name";
            右键菜单_复制CharName.Click += 角色右键菜单_Click;
            // 
            // 右键菜单_复制Account
            // 
            右键菜单_复制Account.Name = "右键菜单_复制Account";
            右键菜单_复制Account.Size = new System.Drawing.Size(191, 22);
            右键菜单_复制Account.Text = "Copy account name";
            右键菜单_复制Account.Click += 角色右键菜单_Click;
            // 
            // 右键菜单_复制网络地址
            // 
            右键菜单_复制网络地址.Name = "右键菜单_复制网络地址";
            右键菜单_复制网络地址.Size = new System.Drawing.Size(191, 22);
            右键菜单_复制网络地址.Text = "Copy IP";
            右键菜单_复制网络地址.Click += 角色右键菜单_Click;
            // 
            // 右键菜单_复制物理地址
            // 
            右键菜单_复制物理地址.Name = "右键菜单_复制物理地址";
            右键菜单_复制物理地址.Size = new System.Drawing.Size(191, 22);
            右键菜单_复制物理地址.Text = "Copy MAC Addr";
            右键菜单_复制物理地址.Click += 角色右键菜单_Click;
            // 
            // tabMaps
            // 
            tabMaps.BackColor = System.Drawing.Color.Gainsboro;
            tabMaps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tabMaps.Controls.Add(dgvMaps);
            tabMaps.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabMaps.Location = new System.Drawing.Point(4, 34);
            tabMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabMaps.Name = "tabMaps";
            tabMaps.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabMaps.Size = new System.Drawing.Size(1733, 817);
            tabMaps.TabIndex = 1;
            tabMaps.Text = "Maps";
            // 
            // dgvMaps
            // 
            dgvMaps.AllowUserToAddRows = false;
            dgvMaps.AllowUserToDeleteRows = false;
            dgvMaps.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dgvMaps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvMaps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaps.BackgroundColor = System.Drawing.Color.LightGray;
            dgvMaps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvMaps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvMaps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvMaps.ColumnHeadersHeight = 29;
            dgvMaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvMaps.DefaultCellStyle = dataGridViewCellStyle18;
            dgvMaps.GridColor = System.Drawing.SystemColors.ActiveCaption;
            dgvMaps.Location = new System.Drawing.Point(0, 5);
            dgvMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgvMaps.MultiSelect = false;
            dgvMaps.Name = "dgvMaps";
            dgvMaps.ReadOnly = true;
            dgvMaps.RowHeadersVisible = false;
            dgvMaps.RowHeadersWidth = 51;
            dgvMaps.RowTemplate.Height = 23;
            dgvMaps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMaps.ShowCellToolTips = false;
            dgvMaps.Size = new System.Drawing.Size(1385, 615);
            dgvMaps.TabIndex = 2;
            // 
            // tabMonsters
            // 
            tabMonsters.BackColor = System.Drawing.Color.Gainsboro;
            tabMonsters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tabMonsters.Controls.Add(掉落浏览表);
            tabMonsters.Controls.Add(怪物浏览表);
            tabMonsters.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabMonsters.Location = new System.Drawing.Point(4, 34);
            tabMonsters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabMonsters.Name = "tabMonsters";
            tabMonsters.Size = new System.Drawing.Size(1733, 817);
            tabMonsters.TabIndex = 2;
            tabMonsters.Text = "Monsters";
            // 
            // 掉落浏览表
            // 
            掉落浏览表.AllowUserToAddRows = false;
            掉落浏览表.AllowUserToDeleteRows = false;
            掉落浏览表.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            掉落浏览表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            掉落浏览表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            掉落浏览表.BackgroundColor = System.Drawing.Color.LightGray;
            掉落浏览表.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            掉落浏览表.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            掉落浏览表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            掉落浏览表.ColumnHeadersHeight = 29;
            掉落浏览表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            掉落浏览表.DefaultCellStyle = dataGridViewCellStyle21;
            掉落浏览表.GridColor = System.Drawing.SystemColors.ActiveCaption;
            掉落浏览表.Location = new System.Drawing.Point(1053, 5);
            掉落浏览表.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            掉落浏览表.MultiSelect = false;
            掉落浏览表.Name = "掉落浏览表";
            掉落浏览表.ReadOnly = true;
            掉落浏览表.RowHeadersVisible = false;
            掉落浏览表.RowHeadersWidth = 51;
            掉落浏览表.RowTemplate.Height = 23;
            掉落浏览表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            掉落浏览表.ShowCellToolTips = false;
            掉落浏览表.Size = new System.Drawing.Size(332, 615);
            掉落浏览表.TabIndex = 5;
            // 
            // 怪物浏览表
            // 
            怪物浏览表.AllowUserToAddRows = false;
            怪物浏览表.AllowUserToDeleteRows = false;
            怪物浏览表.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            怪物浏览表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            怪物浏览表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            怪物浏览表.BackgroundColor = System.Drawing.Color.LightGray;
            怪物浏览表.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            怪物浏览表.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            怪物浏览表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            怪物浏览表.ColumnHeadersHeight = 29;
            怪物浏览表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            怪物浏览表.DefaultCellStyle = dataGridViewCellStyle24;
            怪物浏览表.GridColor = System.Drawing.SystemColors.ActiveCaption;
            怪物浏览表.Location = new System.Drawing.Point(0, 5);
            怪物浏览表.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            怪物浏览表.MultiSelect = false;
            怪物浏览表.Name = "怪物浏览表";
            怪物浏览表.ReadOnly = true;
            怪物浏览表.RowHeadersVisible = false;
            怪物浏览表.RowHeadersWidth = 51;
            怪物浏览表.RowTemplate.Height = 23;
            怪物浏览表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            怪物浏览表.ShowCellToolTips = false;
            怪物浏览表.Size = new System.Drawing.Size(1046, 615);
            怪物浏览表.TabIndex = 3;
            // 
            // tabBans
            // 
            tabBans.BackColor = System.Drawing.Color.Gainsboro;
            tabBans.Controls.Add(封禁浏览表);
            tabBans.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabBans.Location = new System.Drawing.Point(4, 34);
            tabBans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabBans.Name = "tabBans";
            tabBans.Size = new System.Drawing.Size(1733, 817);
            tabBans.TabIndex = 12;
            tabBans.Text = "Bans";
            // 
            // 封禁浏览表
            // 
            封禁浏览表.AllowUserToAddRows = false;
            封禁浏览表.AllowUserToDeleteRows = false;
            封禁浏览表.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            封禁浏览表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            封禁浏览表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            封禁浏览表.BackgroundColor = System.Drawing.Color.LightGray;
            封禁浏览表.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            封禁浏览表.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            封禁浏览表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            封禁浏览表.ColumnHeadersHeight = 29;
            封禁浏览表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            封禁浏览表.DefaultCellStyle = dataGridViewCellStyle27;
            封禁浏览表.GridColor = System.Drawing.SystemColors.ActiveCaption;
            封禁浏览表.Location = new System.Drawing.Point(147, 5);
            封禁浏览表.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            封禁浏览表.MultiSelect = false;
            封禁浏览表.Name = "封禁浏览表";
            封禁浏览表.ReadOnly = true;
            封禁浏览表.RowHeadersVisible = false;
            封禁浏览表.RowHeadersWidth = 51;
            封禁浏览表.RowTemplate.Height = 23;
            封禁浏览表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            封禁浏览表.ShowCellToolTips = false;
            封禁浏览表.Size = new System.Drawing.Size(1000, 615);
            封禁浏览表.TabIndex = 6;
            // 
            // tabAnnouncements
            // 
            tabAnnouncements.BackColor = System.Drawing.Color.Gainsboro;
            tabAnnouncements.Controls.Add(开始公告按钮);
            tabAnnouncements.Controls.Add(停止公告按钮);
            tabAnnouncements.Controls.Add(删除公告按钮);
            tabAnnouncements.Controls.Add(添加公告按钮);
            tabAnnouncements.Controls.Add(公告浏览表);
            tabAnnouncements.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabAnnouncements.Location = new System.Drawing.Point(4, 34);
            tabAnnouncements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabAnnouncements.Name = "tabAnnouncements";
            tabAnnouncements.Size = new System.Drawing.Size(1733, 817);
            tabAnnouncements.TabIndex = 13;
            tabAnnouncements.Text = "Announcements";
            // 
            // 开始公告按钮
            // 
            开始公告按钮.Enabled = false;
            开始公告按钮.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            开始公告按钮.Location = new System.Drawing.Point(6, 562);
            开始公告按钮.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            开始公告按钮.Name = "开始公告按钮";
            开始公告按钮.Size = new System.Drawing.Size(343, 43);
            开始公告按钮.TabIndex = 7;
            开始公告按钮.Text = "Start selected announces";
            开始公告按钮.UseVisualStyleBackColor = true;
            开始公告按钮.Click += StartAnnouncement_Click;
            // 
            // 停止公告按钮
            // 
            停止公告按钮.Enabled = false;
            停止公告按钮.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            停止公告按钮.Location = new System.Drawing.Point(349, 562);
            停止公告按钮.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            停止公告按钮.Name = "停止公告按钮";
            停止公告按钮.Size = new System.Drawing.Size(343, 43);
            停止公告按钮.TabIndex = 6;
            停止公告按钮.Text = "Stop announcements";
            停止公告按钮.UseVisualStyleBackColor = true;
            停止公告按钮.Click += 停止公告按钮_Click;
            // 
            // 删除公告按钮
            // 
            删除公告按钮.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            删除公告按钮.Location = new System.Drawing.Point(1035, 562);
            删除公告按钮.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            删除公告按钮.Name = "删除公告按钮";
            删除公告按钮.Size = new System.Drawing.Size(343, 43);
            删除公告按钮.TabIndex = 5;
            删除公告按钮.Text = "Delete selected announcement";
            删除公告按钮.UseVisualStyleBackColor = true;
            删除公告按钮.Click += 删除公告按钮_Click;
            // 
            // 添加公告按钮
            // 
            添加公告按钮.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            添加公告按钮.Location = new System.Drawing.Point(692, 562);
            添加公告按钮.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            添加公告按钮.Name = "添加公告按钮";
            添加公告按钮.Size = new System.Drawing.Size(343, 43);
            添加公告按钮.TabIndex = 4;
            添加公告按钮.Text = "Add new announcement";
            添加公告按钮.UseVisualStyleBackColor = true;
            添加公告按钮.Click += 添加公告按钮_Click;
            // 
            // 公告浏览表
            // 
            公告浏览表.AllowUserToAddRows = false;
            公告浏览表.AllowUserToDeleteRows = false;
            公告浏览表.AllowUserToResizeColumns = false;
            公告浏览表.AllowUserToResizeRows = false;
            公告浏览表.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            公告浏览表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            公告浏览表.ColumnHeadersHeight = 29;
            公告浏览表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            公告浏览表.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Status, Interval, Count, RemainingTime, Time, Content });
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            公告浏览表.DefaultCellStyle = dataGridViewCellStyle29;
            公告浏览表.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            公告浏览表.Location = new System.Drawing.Point(6, 5);
            公告浏览表.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            公告浏览表.MultiSelect = false;
            公告浏览表.Name = "公告浏览表";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            公告浏览表.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            公告浏览表.RowHeadersVisible = false;
            公告浏览表.RowHeadersWidth = 51;
            公告浏览表.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            公告浏览表.RowTemplate.Height = 23;
            公告浏览表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            公告浏览表.ShowCellToolTips = false;
            公告浏览表.Size = new System.Drawing.Size(1375, 533);
            公告浏览表.TabIndex = 3;
            公告浏览表.TabStop = false;
            公告浏览表.CellEndEdit += 公告浏览表_CellEndEdit;
            公告浏览表.SelectionChanged += 公告浏览表_SelectionChanged;
            // 
            // Status
            // 
            Status.Frozen = true;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 60;
            // 
            // Interval
            // 
            Interval.DataPropertyName = "Interval";
            Interval.Frozen = true;
            Interval.HeaderText = "Interval";
            Interval.MinimumWidth = 6;
            Interval.Name = "Interval";
            Interval.Width = 80;
            // 
            // Count
            // 
            Count.DataPropertyName = "Count";
            Count.Frozen = true;
            Count.HeaderText = "Count";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.Width = 80;
            // 
            // RemainingTime
            // 
            RemainingTime.Frozen = true;
            RemainingTime.HeaderText = "Remaining Time";
            RemainingTime.MinimumWidth = 6;
            RemainingTime.Name = "RemainingTime";
            RemainingTime.ReadOnly = true;
            RemainingTime.Width = 80;
            // 
            // Time
            // 
            Time.Frozen = true;
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 90;
            // 
            // Content
            // 
            Content.DataPropertyName = "Content";
            Content.Frozen = true;
            Content.HeaderText = "Content";
            Content.MinimumWidth = 6;
            Content.Name = "Content";
            Content.Width = 884;
            // 
            // tabConfig
            // 
            tabConfig.BackColor = System.Drawing.Color.Gainsboro;
            tabConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tabConfig.Controls.Add(S_软件授权分组);
            tabConfig.Controls.Add(S_GameData分组);
            tabConfig.Controls.Add(S_游戏设置分组);
            tabConfig.Controls.Add(S_网络设置分组);
            tabConfig.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabConfig.Location = new System.Drawing.Point(4, 34);
            tabConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabConfig.Name = "tabConfig";
            tabConfig.Size = new System.Drawing.Size(1733, 817);
            tabConfig.TabIndex = 11;
            tabConfig.Text = "Config";
            // 
            // S_软件授权分组
            // 
            S_软件授权分组.Controls.Add(S_软件注册代码);
            S_软件授权分组.Location = new System.Drawing.Point(18, 524);
            S_软件授权分组.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_软件授权分组.Name = "S_软件授权分组";
            S_软件授权分组.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_软件授权分组.Size = new System.Drawing.Size(690, 77);
            S_软件授权分组.TabIndex = 11;
            S_软件授权分组.TabStop = false;
            S_软件授权分组.Text = "Registration code";
            // 
            // S_软件注册代码
            // 
            S_软件注册代码.Location = new System.Drawing.Point(7, 29);
            S_软件注册代码.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_软件注册代码.Name = "S_软件注册代码";
            S_软件注册代码.Size = new System.Drawing.Size(675, 21);
            S_软件注册代码.TabIndex = 11;
            S_软件注册代码.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // S_GameData分组
            // 
            S_GameData分组.Controls.Add(label1);
            S_GameData分组.Controls.Add(S_注意事项标签8);
            S_GameData分组.Controls.Add(S_注意事项标签7);
            S_GameData分组.Controls.Add(S_注意事项标签6);
            S_GameData分组.Controls.Add(S_注意事项标签5);
            S_GameData分组.Controls.Add(S_注意事项标签4);
            S_GameData分组.Controls.Add(S_注意事项标签3);
            S_GameData分组.Controls.Add(S_注意事项标签2);
            S_GameData分组.Controls.Add(S_注意事项标签1);
            S_GameData分组.Controls.Add(S_重载客户数据);
            S_GameData分组.Controls.Add(S_重载SystemData);
            S_GameData分组.Controls.Add(S_浏览合并目录);
            S_GameData分组.Controls.Add(S_浏览备份目录);
            S_GameData分组.Controls.Add(S_浏览数据目录);
            S_GameData分组.Controls.Add(S_合并客户数据);
            S_GameData分组.Controls.Add(S_合并数据目录);
            S_GameData分组.Controls.Add(S_合并目录标签);
            S_GameData分组.Controls.Add(S_数据备份目录);
            S_GameData分组.Controls.Add(S_GameData目录);
            S_GameData分组.Controls.Add(S_备份目录标签);
            S_GameData分组.Controls.Add(S_数据目录标签);
            S_GameData分组.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_GameData分组.Location = new System.Drawing.Point(741, 17);
            S_GameData分组.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_GameData分组.Name = "S_GameData分组";
            S_GameData分组.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_GameData分组.Size = new System.Drawing.Size(571, 586);
            S_GameData分组.TabIndex = 10;
            S_GameData分组.TabStop = false;
            S_GameData分组.Text = "GameData";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Location = new System.Drawing.Point(24, 536);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(425, 15);
            label1.TabIndex = 28;
            label1.Text = "Incoming % exp defines the amount of less exp received until max lvl exp cap";
            // 
            // S_注意事项标签8
            // 
            S_注意事项标签8.AutoSize = true;
            S_注意事项标签8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_注意事项标签8.ForeColor = System.Drawing.Color.Blue;
            S_注意事项标签8.Location = new System.Drawing.Point(24, 507);
            S_注意事项标签8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_注意事项标签8.Name = "S_注意事项标签8";
            S_注意事项标签8.Size = new System.Drawing.Size(432, 15);
            S_注意事项标签8.TabIndex = 27;
            S_注意事项标签8.Text = "Max Lvl Exp defines the cap level for your exp reduction, after this, you will get 0";
            S_注意事项标签8.Click += S_注意事项标签8_Click;
            // 
            // S_注意事项标签7
            // 
            S_注意事项标签7.AutoSize = true;
            S_注意事项标签7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_注意事项标签7.ForeColor = System.Drawing.Color.Blue;
            S_注意事项标签7.Location = new System.Drawing.Point(24, 478);
            S_注意事项标签7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_注意事项标签7.Name = "S_注意事项标签7";
            S_注意事项标签7.Size = new System.Drawing.Size(188, 15);
            S_注意事项标签7.TabIndex = 26;
            S_注意事项标签7.Text = "Max Player it's cap level on server";
            // 
            // S_注意事项标签6
            // 
            S_注意事项标签6.AutoSize = true;
            S_注意事项标签6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_注意事项标签6.ForeColor = System.Drawing.Color.Blue;
            S_注意事项标签6.Location = new System.Drawing.Point(24, 449);
            S_注意事项标签6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_注意事项标签6.Name = "S_注意事项标签6";
            S_注意事项标签6.Size = new System.Drawing.Size(367, 15);
            S_注意事项标签6.TabIndex = 25;
            S_注意事项标签6.Text = "Noob Level means get double exp % adquired until lvl on settings ";
            S_注意事项标签6.Click += S_注意事项标签6_Click;
            // 
            // S_注意事项标签5
            // 
            S_注意事项标签5.AutoSize = true;
            S_注意事项标签5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_注意事项标签5.ForeColor = System.Drawing.Color.Blue;
            S_注意事项标签5.Location = new System.Drawing.Point(24, 419);
            S_注意事项标签5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_注意事项标签5.Name = "S_注意事项标签5";
            S_注意事项标签5.Size = new System.Drawing.Size(354, 15);
            S_注意事项标签5.TabIndex = 24;
            S_注意事项标签5.Text = "Wiz Tame defines the maximum time of a pet with ElectricShock";
            S_注意事项标签5.Click += S_注意事项标签5_Click;
            // 
            // S_注意事项标签4
            // 
            S_注意事项标签4.AutoSize = true;
            S_注意事项标签4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_注意事项标签4.ForeColor = System.Drawing.Color.Blue;
            S_注意事项标签4.Location = new System.Drawing.Point(24, 394);
            S_注意事项标签4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_注意事项标签4.Name = "S_注意事项标签4";
            S_注意事项标签4.Size = new System.Drawing.Size(551, 15);
            S_注意事项标签4.TabIndex = 23;
            S_注意事项标签4.Text = "The rate of gain reduction is a set rate of experience and rate reduction for each level beyond Level 1";
            // 
            // S_注意事项标签3
            // 
            S_注意事项标签3.AutoSize = true;
            S_注意事项标签3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_注意事项标签3.ForeColor = System.Drawing.Color.Blue;
            S_注意事项标签3.Location = new System.Drawing.Point(24, 377);
            S_注意事项标签3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_注意事项标签3.Name = "S_注意事项标签3";
            S_注意事项标签3.Size = new System.Drawing.Size(539, 15);
            S_注意事项标签3.TabIndex = 22;
            S_注意事项标签3.Text = "Extra Drop Formula: 1/(X - X * Extra Drop Rate), X means how many times randomly dropped once";
            S_注意事项标签3.Click += S_注意事项标签3_Click;
            // 
            // S_注意事项标签2
            // 
            S_注意事项标签2.AutoSize = true;
            S_注意事项标签2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_注意事项标签2.ForeColor = System.Drawing.Color.Blue;
            S_注意事项标签2.Location = new System.Drawing.Point(24, 355);
            S_注意事项标签2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_注意事项标签2.Name = "S_注意事项标签2";
            S_注意事项标签2.Size = new System.Drawing.Size(369, 15);
            S_注意事项标签2.TabIndex = 20;
            S_注意事项标签2.Text = "Item Ownership defines the time of an item from mobs on the floor";
            // 
            // S_注意事项标签1
            // 
            S_注意事项标签1.AutoSize = true;
            S_注意事项标签1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_注意事项标签1.ForeColor = System.Drawing.Color.Blue;
            S_注意事项标签1.Location = new System.Drawing.Point(20, 328);
            S_注意事项标签1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_注意事项标签1.Name = "S_注意事项标签1";
            S_注意事项标签1.Size = new System.Drawing.Size(458, 15);
            S_注意事项标签1.TabIndex = 21;
            S_注意事项标签1.Text = "Settings info: All time settings on this page are in minutes, please note the settings";
            // 
            // S_重载客户数据
            // 
            S_重载客户数据.Location = new System.Drawing.Point(20, 162);
            S_重载客户数据.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_重载客户数据.Name = "S_重载客户数据";
            S_重载客户数据.Size = new System.Drawing.Size(518, 33);
            S_重载客户数据.TabIndex = 13;
            S_重载客户数据.Text = "Reload users database";
            S_重载客户数据.UseVisualStyleBackColor = true;
            S_重载客户数据.Click += 重载客户数据_Click;
            // 
            // S_重载SystemData
            // 
            S_重载SystemData.Location = new System.Drawing.Point(20, 122);
            S_重载SystemData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_重载SystemData.Name = "S_重载SystemData";
            S_重载SystemData.Size = new System.Drawing.Size(518, 33);
            S_重载SystemData.TabIndex = 12;
            S_重载SystemData.Text = "Reload system data";
            S_重载SystemData.UseVisualStyleBackColor = true;
            S_重载SystemData.Click += 重载SystemData_Click;
            // 
            // S_浏览合并目录
            // 
            S_浏览合并目录.Location = new System.Drawing.Point(511, 235);
            S_浏览合并目录.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_浏览合并目录.Name = "S_浏览合并目录";
            S_浏览合并目录.Size = new System.Drawing.Size(27, 33);
            S_浏览合并目录.TabIndex = 11;
            S_浏览合并目录.Text = "S";
            S_浏览合并目录.UseVisualStyleBackColor = true;
            S_浏览合并目录.Click += 选择数据目录_Click;
            // 
            // S_浏览备份目录
            // 
            S_浏览备份目录.Location = new System.Drawing.Point(511, 77);
            S_浏览备份目录.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_浏览备份目录.Name = "S_浏览备份目录";
            S_浏览备份目录.Size = new System.Drawing.Size(27, 33);
            S_浏览备份目录.TabIndex = 10;
            S_浏览备份目录.Text = "S";
            S_浏览备份目录.UseVisualStyleBackColor = true;
            S_浏览备份目录.Click += 选择数据目录_Click;
            // 
            // S_浏览数据目录
            // 
            S_浏览数据目录.Location = new System.Drawing.Point(511, 35);
            S_浏览数据目录.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_浏览数据目录.Name = "S_浏览数据目录";
            S_浏览数据目录.Size = new System.Drawing.Size(27, 33);
            S_浏览数据目录.TabIndex = 9;
            S_浏览数据目录.Text = "S";
            S_浏览数据目录.UseVisualStyleBackColor = true;
            S_浏览数据目录.Click += 选择数据目录_Click;
            // 
            // S_合并客户数据
            // 
            S_合并客户数据.Location = new System.Drawing.Point(20, 280);
            S_合并客户数据.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_合并客户数据.Name = "S_合并客户数据";
            S_合并客户数据.Size = new System.Drawing.Size(518, 33);
            S_合并客户数据.TabIndex = 8;
            S_合并客户数据.Text = "Save users data";
            S_合并客户数据.UseVisualStyleBackColor = true;
            S_合并客户数据.Click += 合并客户数据_Click;
            // 
            // S_合并数据目录
            // 
            S_合并数据目录.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_合并数据目录.Location = new System.Drawing.Point(133, 238);
            S_合并数据目录.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_合并数据目录.Name = "S_合并数据目录";
            S_合并数据目录.Size = new System.Drawing.Size(382, 21);
            S_合并数据目录.TabIndex = 7;
            // 
            // S_合并目录标签
            // 
            S_合并目录标签.AutoSize = true;
            S_合并目录标签.Location = new System.Drawing.Point(20, 246);
            S_合并目录标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_合并目录标签.Name = "S_合并目录标签";
            S_合并目录标签.Size = new System.Drawing.Size(82, 15);
            S_合并目录标签.TabIndex = 6;
            S_合并目录标签.Text = "Data directory";
            // 
            // S_数据备份目录
            // 
            S_数据备份目录.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_数据备份目录.Location = new System.Drawing.Point(133, 79);
            S_数据备份目录.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_数据备份目录.Name = "S_数据备份目录";
            S_数据备份目录.ReadOnly = true;
            S_数据备份目录.Size = new System.Drawing.Size(382, 21);
            S_数据备份目录.TabIndex = 5;
            S_数据备份目录.Text = ".\\Backup";
            // 
            // S_GameData目录
            // 
            S_GameData目录.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_GameData目录.Location = new System.Drawing.Point(133, 39);
            S_GameData目录.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_GameData目录.Name = "S_GameData目录";
            S_GameData目录.ReadOnly = true;
            S_GameData目录.Size = new System.Drawing.Size(382, 21);
            S_GameData目录.TabIndex = 4;
            S_GameData目录.Text = ".\\Database";
            // 
            // S_备份目录标签
            // 
            S_备份目录标签.AutoSize = true;
            S_备份目录标签.Location = new System.Drawing.Point(20, 86);
            S_备份目录标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_备份目录标签.Name = "S_备份目录标签";
            S_备份目录标签.Size = new System.Drawing.Size(82, 15);
            S_备份目录标签.TabIndex = 3;
            S_备份目录标签.Text = "Backup folder";
            // 
            // S_数据目录标签
            // 
            S_数据目录标签.AutoSize = true;
            S_数据目录标签.Location = new System.Drawing.Point(20, 45);
            S_数据目录标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_数据目录标签.Name = "S_数据目录标签";
            S_数据目录标签.Size = new System.Drawing.Size(103, 15);
            S_数据目录标签.TabIndex = 1;
            S_数据目录标签.Text = "Gamedata Folder";
            // 
            // S_游戏设置分组
            // 
            S_游戏设置分组.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            S_游戏设置分组.Controls.Add(L_NoobLevel);
            S_游戏设置分组.Controls.Add(S_NoobLevel);
            S_游戏设置分组.Controls.Add(S_物品归属标签);
            S_游戏设置分组.Controls.Add(S_ItemOwnershipTime);
            S_游戏设置分组.Controls.Add(S_收益衰减标签);
            S_游戏设置分组.Controls.Add(S_物品清理标签);
            S_游戏设置分组.Controls.Add(S_ItemCleaningTime);
            S_游戏设置分组.Controls.Add(S_诱惑时长标签);
            S_游戏设置分组.Controls.Add(S_TemptationTime);
            S_游戏设置分组.Controls.Add(S_LessExpGradeRate);
            S_游戏设置分组.Controls.Add(S_收益等级标签);
            S_游戏设置分组.Controls.Add(S_LessExpGrade);
            S_游戏设置分组.Controls.Add(S_经验倍率标签);
            S_游戏设置分组.Controls.Add(S_ExpRate);
            S_游戏设置分组.Controls.Add(S_特修折扣标签);
            S_游戏设置分组.Controls.Add(S_EquipRepairDto);
            S_游戏设置分组.Controls.Add(S_怪物爆率标签);
            S_游戏设置分组.Controls.Add(S_ExtraDropRate);
            S_游戏设置分组.Controls.Add(S_OpenLevelCommand标签);
            S_游戏设置分组.Controls.Add(S_MaxLevel);
            S_游戏设置分组.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_游戏设置分组.Location = new System.Drawing.Point(350, 17);
            S_游戏设置分组.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_游戏设置分组.Name = "S_游戏设置分组";
            S_游戏设置分组.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_游戏设置分组.Size = new System.Drawing.Size(357, 476);
            S_游戏设置分组.TabIndex = 8;
            S_游戏设置分组.TabStop = false;
            S_游戏设置分组.Text = "Game Settings";
            // 
            // L_NoobLevel
            // 
            L_NoobLevel.AutoSize = true;
            L_NoobLevel.Location = new System.Drawing.Point(70, 90);
            L_NoobLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_NoobLevel.Name = "L_NoobLevel";
            L_NoobLevel.Size = new System.Drawing.Size(69, 15);
            L_NoobLevel.TabIndex = 21;
            L_NoobLevel.Text = "Noob Level";
            // 
            // S_NoobLevel
            // 
            S_NoobLevel.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_NoobLevel.Location = new System.Drawing.Point(189, 80);
            S_NoobLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_NoobLevel.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            S_NoobLevel.Name = "S_NoobLevel";
            S_NoobLevel.Size = new System.Drawing.Size(127, 24);
            S_NoobLevel.TabIndex = 20;
            S_NoobLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // S_物品归属标签
            // 
            S_物品归属标签.AutoSize = true;
            S_物品归属标签.Location = new System.Drawing.Point(41, 419);
            S_物品归属标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_物品归属标签.Name = "S_物品归属标签";
            S_物品归属标签.Size = new System.Drawing.Size(125, 15);
            S_物品归属标签.TabIndex = 19;
            S_物品归属标签.Text = "Item Ownership Time";
            // 
            // S_ItemOwnershipTime
            // 
            S_ItemOwnershipTime.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_ItemOwnershipTime.Location = new System.Drawing.Point(189, 409);
            S_ItemOwnershipTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_ItemOwnershipTime.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            S_ItemOwnershipTime.Name = "S_ItemOwnershipTime";
            S_ItemOwnershipTime.Size = new System.Drawing.Size(127, 24);
            S_ItemOwnershipTime.TabIndex = 18;
            S_ItemOwnershipTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_ItemOwnershipTime.ValueChanged += 更改设置Value_Value;
            // 
            // S_收益衰减标签
            // 
            S_收益衰减标签.AutoSize = true;
            S_收益衰减标签.Location = new System.Drawing.Point(15, 296);
            S_收益衰减标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_收益衰减标签.Name = "S_收益衰减标签";
            S_收益衰减标签.Size = new System.Drawing.Size(148, 15);
            S_收益衰减标签.TabIndex = 13;
            S_收益衰减标签.Text = "Incoming % exp reduction";
            // 
            // S_物品清理标签
            // 
            S_物品清理标签.AutoSize = true;
            S_物品清理标签.Location = new System.Drawing.Point(70, 377);
            S_物品清理标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_物品清理标签.Name = "S_物品清理标签";
            S_物品清理标签.Size = new System.Drawing.Size(90, 15);
            S_物品清理标签.TabIndex = 17;
            S_物品清理标签.Text = "Item disappear";
            // 
            // S_ItemCleaningTime
            // 
            S_ItemCleaningTime.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_ItemCleaningTime.Location = new System.Drawing.Point(189, 373);
            S_ItemCleaningTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_ItemCleaningTime.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            S_ItemCleaningTime.Name = "S_ItemCleaningTime";
            S_ItemCleaningTime.Size = new System.Drawing.Size(127, 24);
            S_ItemCleaningTime.TabIndex = 16;
            S_ItemCleaningTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_ItemCleaningTime.ValueChanged += 更改设置Value_Value;
            // 
            // S_诱惑时长标签
            // 
            S_诱惑时长标签.AutoSize = true;
            S_诱惑时长标签.Location = new System.Drawing.Point(70, 335);
            S_诱惑时长标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_诱惑时长标签.Name = "S_诱惑时长标签";
            S_诱惑时长标签.Size = new System.Drawing.Size(86, 15);
            S_诱惑时长标签.TabIndex = 15;
            S_诱惑时长标签.Text = "Wiz Tame Skill";
            // 
            // S_TemptationTime
            // 
            S_TemptationTime.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_TemptationTime.Location = new System.Drawing.Point(189, 328);
            S_TemptationTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_TemptationTime.Maximum = new decimal(new int[] { 1200, 0, 0, 0 });
            S_TemptationTime.Name = "S_TemptationTime";
            S_TemptationTime.Size = new System.Drawing.Size(127, 24);
            S_TemptationTime.TabIndex = 14;
            S_TemptationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_TemptationTime.ValueChanged += 更改设置Value_Value;
            // 
            // S_LessExpGradeRate
            // 
            S_LessExpGradeRate.DecimalPlaces = 2;
            S_LessExpGradeRate.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_LessExpGradeRate.Location = new System.Drawing.Point(189, 286);
            S_LessExpGradeRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_LessExpGradeRate.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            S_LessExpGradeRate.Name = "S_LessExpGradeRate";
            S_LessExpGradeRate.Size = new System.Drawing.Size(127, 24);
            S_LessExpGradeRate.TabIndex = 12;
            S_LessExpGradeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_LessExpGradeRate.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            S_LessExpGradeRate.ValueChanged += 更改设置Value_Value;
            // 
            // S_收益等级标签
            // 
            S_收益等级标签.AutoSize = true;
            S_收益等级标签.Location = new System.Drawing.Point(0, 256);
            S_收益等级标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_收益等级标签.Name = "S_收益等级标签";
            S_收益等级标签.Size = new System.Drawing.Size(190, 15);
            S_收益等级标签.TabIndex = 11;
            S_收益等级标签.Text = "Max Lvl Exp Received From mobs";
            // 
            // S_LessExpGrade
            // 
            S_LessExpGrade.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_LessExpGrade.Location = new System.Drawing.Point(189, 246);
            S_LessExpGrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_LessExpGrade.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            S_LessExpGrade.Name = "S_LessExpGrade";
            S_LessExpGrade.Size = new System.Drawing.Size(127, 24);
            S_LessExpGrade.TabIndex = 10;
            S_LessExpGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_LessExpGrade.ValueChanged += 更改设置Value_Value;
            // 
            // S_经验倍率标签
            // 
            S_经验倍率标签.AutoSize = true;
            S_经验倍率标签.Location = new System.Drawing.Point(70, 212);
            S_经验倍率标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_经验倍率标签.Name = "S_经验倍率标签";
            S_经验倍率标签.Size = new System.Drawing.Size(56, 15);
            S_经验倍率标签.TabIndex = 9;
            S_经验倍率标签.Text = "Exp Rate";
            // 
            // S_ExpRate
            // 
            S_ExpRate.DecimalPlaces = 2;
            S_ExpRate.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_ExpRate.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            S_ExpRate.Location = new System.Drawing.Point(189, 202);
            S_ExpRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_ExpRate.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            S_ExpRate.Name = "S_ExpRate";
            S_ExpRate.Size = new System.Drawing.Size(127, 24);
            S_ExpRate.TabIndex = 8;
            S_ExpRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_ExpRate.ValueChanged += 更改设置Value_Value;
            // 
            // S_特修折扣标签
            // 
            S_特修折扣标签.AutoSize = true;
            S_特修折扣标签.Location = new System.Drawing.Point(70, 130);
            S_特修折扣标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_特修折扣标签.Name = "S_特修折扣标签";
            S_特修折扣标签.Size = new System.Drawing.Size(94, 15);
            S_特修折扣标签.TabIndex = 7;
            S_特修折扣标签.Text = "Repair discount";
            // 
            // S_EquipRepairDto
            // 
            S_EquipRepairDto.DecimalPlaces = 2;
            S_EquipRepairDto.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_EquipRepairDto.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            S_EquipRepairDto.Location = new System.Drawing.Point(189, 120);
            S_EquipRepairDto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_EquipRepairDto.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            S_EquipRepairDto.Name = "S_EquipRepairDto";
            S_EquipRepairDto.Size = new System.Drawing.Size(127, 24);
            S_EquipRepairDto.TabIndex = 6;
            S_EquipRepairDto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_EquipRepairDto.ValueChanged += 更改设置Value_Value;
            // 
            // S_怪物爆率标签
            // 
            S_怪物爆率标签.AutoSize = true;
            S_怪物爆率标签.Location = new System.Drawing.Point(70, 172);
            S_怪物爆率标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_怪物爆率标签.Name = "S_怪物爆率标签";
            S_怪物爆率标签.Size = new System.Drawing.Size(93, 15);
            S_怪物爆率标签.TabIndex = 5;
            S_怪物爆率标签.Text = "Extra Drop Rate";
            // 
            // S_ExtraDropRate
            // 
            S_ExtraDropRate.DecimalPlaces = 2;
            S_ExtraDropRate.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_ExtraDropRate.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            S_ExtraDropRate.Location = new System.Drawing.Point(189, 162);
            S_ExtraDropRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_ExtraDropRate.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            S_ExtraDropRate.Name = "S_ExtraDropRate";
            S_ExtraDropRate.Size = new System.Drawing.Size(127, 24);
            S_ExtraDropRate.TabIndex = 4;
            S_ExtraDropRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_ExtraDropRate.ValueChanged += 更改设置Value_Value;
            // 
            // S_OpenLevelCommand标签
            // 
            S_OpenLevelCommand标签.AutoSize = true;
            S_OpenLevelCommand标签.Location = new System.Drawing.Point(70, 49);
            S_OpenLevelCommand标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_OpenLevelCommand标签.Name = "S_OpenLevelCommand标签";
            S_OpenLevelCommand标签.Size = new System.Drawing.Size(97, 15);
            S_OpenLevelCommand标签.TabIndex = 3;
            S_OpenLevelCommand标签.Text = "Max Player Level";
            // 
            // S_MaxLevel
            // 
            S_MaxLevel.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_MaxLevel.Location = new System.Drawing.Point(189, 39);
            S_MaxLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_MaxLevel.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            S_MaxLevel.Name = "S_MaxLevel";
            S_MaxLevel.Size = new System.Drawing.Size(127, 24);
            S_MaxLevel.TabIndex = 2;
            S_MaxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_MaxLevel.ValueChanged += 更改设置Value_Value;
            // 
            // S_网络设置分组
            // 
            S_网络设置分组.Controls.Add(S_掉线判定标签);
            S_网络设置分组.Controls.Add(S_DisconnectTime);
            S_网络设置分组.Controls.Add(S_限定封包标签);
            S_网络设置分组.Controls.Add(S_PacketLimit);
            S_网络设置分组.Controls.Add(L_AbnormalBlockTime);
            S_网络设置分组.Controls.Add(S_AbnormalBlockTime);
            S_网络设置分组.Controls.Add(S_接收端口标签);
            S_网络设置分组.Controls.Add(S_TSPort);
            S_网络设置分组.Controls.Add(S_监听端口标签);
            S_网络设置分组.Controls.Add(S_GSPort);
            S_网络设置分组.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_网络设置分组.Location = new System.Drawing.Point(18, 17);
            S_网络设置分组.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_网络设置分组.Name = "S_网络设置分组";
            S_网络设置分组.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_网络设置分组.Size = new System.Drawing.Size(298, 476);
            S_网络设置分组.TabIndex = 0;
            S_网络设置分组.TabStop = false;
            S_网络设置分组.Text = "Network Settings";
            // 
            // S_掉线判定标签
            // 
            S_掉线判定标签.AutoSize = true;
            S_掉线判定标签.Location = new System.Drawing.Point(32, 209);
            S_掉线判定标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_掉线判定标签.Name = "S_掉线判定标签";
            S_掉线判定标签.Size = new System.Drawing.Size(100, 15);
            S_掉线判定标签.TabIndex = 9;
            S_掉线判定标签.Text = "Disconnect Time";
            // 
            // S_DisconnectTime
            // 
            S_DisconnectTime.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_DisconnectTime.Location = new System.Drawing.Point(144, 204);
            S_DisconnectTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_DisconnectTime.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            S_DisconnectTime.Name = "S_DisconnectTime";
            S_DisconnectTime.Size = new System.Drawing.Size(127, 24);
            S_DisconnectTime.TabIndex = 8;
            S_DisconnectTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_DisconnectTime.ValueChanged += 更改设置Value_Value;
            // 
            // S_限定封包标签
            // 
            S_限定封包标签.AutoSize = true;
            S_限定封包标签.Location = new System.Drawing.Point(32, 127);
            S_限定封包标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_限定封包标签.Name = "S_限定封包标签";
            S_限定封包标签.Size = new System.Drawing.Size(70, 15);
            S_限定封包标签.TabIndex = 7;
            S_限定封包标签.Text = "Packet limit";
            // 
            // S_PacketLimit
            // 
            S_PacketLimit.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_PacketLimit.Location = new System.Drawing.Point(144, 122);
            S_PacketLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_PacketLimit.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            S_PacketLimit.Name = "S_PacketLimit";
            S_PacketLimit.Size = new System.Drawing.Size(127, 24);
            S_PacketLimit.TabIndex = 6;
            S_PacketLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_PacketLimit.ValueChanged += 更改设置Value_Value;
            // 
            // L_AbnormalBlockTime
            // 
            L_AbnormalBlockTime.AutoSize = true;
            L_AbnormalBlockTime.Location = new System.Drawing.Point(32, 169);
            L_AbnormalBlockTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_AbnormalBlockTime.Name = "L_AbnormalBlockTime";
            L_AbnormalBlockTime.Size = new System.Drawing.Size(64, 15);
            L_AbnormalBlockTime.TabIndex = 5;
            L_AbnormalBlockTime.Text = "Block time";
            // 
            // S_AbnormalBlockTime
            // 
            S_AbnormalBlockTime.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_AbnormalBlockTime.Location = new System.Drawing.Point(144, 162);
            S_AbnormalBlockTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_AbnormalBlockTime.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            S_AbnormalBlockTime.Name = "S_AbnormalBlockTime";
            S_AbnormalBlockTime.Size = new System.Drawing.Size(127, 24);
            S_AbnormalBlockTime.TabIndex = 4;
            S_AbnormalBlockTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_AbnormalBlockTime.ValueChanged += 更改设置Value_Value;
            // 
            // S_接收端口标签
            // 
            S_接收端口标签.AutoSize = true;
            S_接收端口标签.Location = new System.Drawing.Point(32, 86);
            S_接收端口标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_接收端口标签.Name = "S_接收端口标签";
            S_接收端口标签.Size = new System.Drawing.Size(47, 15);
            S_接收端口标签.TabIndex = 3;
            S_接收端口标签.Text = "TS Port";
            // 
            // S_TSPort
            // 
            S_TSPort.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_TSPort.Location = new System.Drawing.Point(144, 80);
            S_TSPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_TSPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            S_TSPort.Name = "S_TSPort";
            S_TSPort.Size = new System.Drawing.Size(127, 24);
            S_TSPort.TabIndex = 2;
            S_TSPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_TSPort.ValueChanged += 更改设置Value_Value;
            // 
            // S_监听端口标签
            // 
            S_监听端口标签.AutoSize = true;
            S_监听端口标签.Location = new System.Drawing.Point(32, 45);
            S_监听端口标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            S_监听端口标签.Name = "S_监听端口标签";
            S_监听端口标签.Size = new System.Drawing.Size(67, 15);
            S_监听端口标签.TabIndex = 1;
            S_监听端口标签.Text = "Server Port";
            // 
            // S_GSPort
            // 
            S_GSPort.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S_GSPort.Location = new System.Drawing.Point(144, 39);
            S_GSPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            S_GSPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            S_GSPort.Name = "S_GSPort";
            S_GSPort.Size = new System.Drawing.Size(127, 24);
            S_GSPort.TabIndex = 0;
            S_GSPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            S_GSPort.ValueChanged += 更改设置Value_Value;
            // 
            // 界面定时更新
            // 
            界面定时更新.Interval = 2500;
            // 
            // 下方控件页
            // 
            下方控件页.BackColor = System.Drawing.Color.Transparent;
            下方控件页.Controls.Add(保存按钮);
            下方控件页.Controls.Add(GMCommand文本);
            下方控件页.Controls.Add(GMCommand标签);
            下方控件页.Controls.Add(启动按钮);
            下方控件页.Controls.Add(停止按钮);
            下方控件页.Location = new System.Drawing.Point(4, 680);
            下方控件页.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            下方控件页.Name = "下方控件页";
            下方控件页.Size = new System.Drawing.Size(1397, 85);
            下方控件页.TabIndex = 6;
            // 
            // 保存按钮
            // 
            保存按钮.BackColor = System.Drawing.Color.LightSteelBlue;
            保存按钮.Enabled = false;
            保存按钮.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            保存按钮.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            保存按钮.Image = Properties.Resources.Save_Image;
            保存按钮.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            保存按钮.Location = new System.Drawing.Point(918, 9);
            保存按钮.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            保存按钮.Name = "保存按钮";
            保存按钮.Size = new System.Drawing.Size(153, 54);
            保存按钮.TabIndex = 17;
            保存按钮.Text = "Save Data";
            保存按钮.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            保存按钮.UseVisualStyleBackColor = false;
            保存按钮.Click += 保存数据库_Click;
            // 
            // GMCommand文本
            // 
            GMCommand文本.BackColor = System.Drawing.SystemColors.InactiveCaption;
            GMCommand文本.Location = new System.Drawing.Point(95, 23);
            GMCommand文本.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            GMCommand文本.Name = "GMCommand文本";
            GMCommand文本.Size = new System.Drawing.Size(815, 23);
            GMCommand文本.TabIndex = 16;
            GMCommand文本.KeyPress += 执行GMCommand行_Press;
            // 
            // GMCommand标签
            // 
            GMCommand标签.AutoSize = true;
            GMCommand标签.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            GMCommand标签.Location = new System.Drawing.Point(21, 29);
            GMCommand标签.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            GMCommand标签.Name = "GMCommand标签";
            GMCommand标签.Size = new System.Drawing.Size(66, 16);
            GMCommand标签.TabIndex = 13;
            GMCommand标签.Text = "GM Box:";
            GMCommand标签.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // 启动按钮
            // 
            启动按钮.BackColor = System.Drawing.Color.LightSteelBlue;
            启动按钮.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            启动按钮.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            启动按钮.ForeColor = System.Drawing.Color.Green;
            启动按钮.Image = Properties.Resources.Start_Image;
            启动按钮.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            启动按钮.Location = new System.Drawing.Point(1078, 9);
            启动按钮.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            启动按钮.Name = "启动按钮";
            启动按钮.Size = new System.Drawing.Size(153, 54);
            启动按钮.TabIndex = 12;
            启动按钮.Text = "Start";
            启动按钮.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            启动按钮.UseVisualStyleBackColor = false;
            启动按钮.Click += 启动服务器_Click;
            // 
            // 停止按钮
            // 
            停止按钮.BackColor = System.Drawing.Color.LightSteelBlue;
            停止按钮.Enabled = false;
            停止按钮.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            停止按钮.ForeColor = System.Drawing.Color.Brown;
            停止按钮.Image = Properties.Resources.Stop_Image;
            停止按钮.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            停止按钮.Location = new System.Drawing.Point(1238, 9);
            停止按钮.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            停止按钮.Name = "停止按钮";
            停止按钮.Size = new System.Drawing.Size(153, 54);
            停止按钮.TabIndex = 11;
            停止按钮.Text = "Stop";
            停止按钮.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            停止按钮.UseVisualStyleBackColor = false;
            停止按钮.Click += 停止服务器_Click;
            // 
            // 保存数据提醒
            // 
            保存数据提醒.Enabled = true;
            保存数据提醒.Interval = 500;
            保存数据提醒.Tick += 保存数据提醒_Tick;
            // 
            // 定时发送公告
            // 
            定时发送公告.Tick += 定时发送公告_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1397, 749);
            Controls.Add(下方控件页);
            Controls.Add(主选项卡);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GameServer - Mir3D LOMCN";
            FormClosing += 关闭主界面_Click;
            Load += MainForm_Load;
            主选项卡.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabMain.PerformLayout();
            MainTabs.ResumeLayout(false);
            tabSystem.ResumeLayout(false);
            tabChat.ResumeLayout(false);
            tabCommands.ResumeLayout(false);
            tabPackets.ResumeLayout(false);
            tabCharacters.ResumeLayout(false);
            角色详情选项卡.ResumeLayout(false);
            CharacterData_技能.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)技能浏览表).EndInit();
            CharacterData_装备.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)装备浏览表).EndInit();
            CharacterData_背包.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)背包浏览表).EndInit();
            CharacterData_仓库.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)仓库浏览表).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).EndInit();
            角色右键菜单.ResumeLayout(false);
            tabMaps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaps).EndInit();
            tabMonsters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)掉落浏览表).EndInit();
            ((System.ComponentModel.ISupportInitialize)怪物浏览表).EndInit();
            tabBans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)封禁浏览表).EndInit();
            tabAnnouncements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)公告浏览表).EndInit();
            tabConfig.ResumeLayout(false);
            S_软件授权分组.ResumeLayout(false);
            S_软件授权分组.PerformLayout();
            S_GameData分组.ResumeLayout(false);
            S_GameData分组.PerformLayout();
            S_游戏设置分组.ResumeLayout(false);
            S_游戏设置分组.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)S_NoobLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_ItemOwnershipTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_ItemCleaningTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_TemptationTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_LessExpGradeRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_LessExpGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_ExpRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_EquipRepairDto).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_ExtraDropRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_MaxLevel).EndInit();
            S_网络设置分组.ResumeLayout(false);
            S_网络设置分组.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)S_DisconnectTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_PacketLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_AbnormalBlockTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_TSPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_GSPort).EndInit();
            下方控件页.ResumeLayout(false);
            下方控件页.PerformLayout();
            ResumeLayout(false);
        }

        private global::System.ComponentModel.IContainer components;


    private global::System.Windows.Forms.RichTextBox 系统日志;


    private global::System.Windows.Forms.Label 帧数统计;


    private global::System.Windows.Forms.Button 保存系统日志;


    private global::System.Windows.Forms.Button 清空系统日志;


    private global::System.Windows.Forms.Label 发送统计;


    private global::System.Windows.Forms.Label 接收统计;


    private global::System.Windows.Forms.Label 已经上线统计;


    private global::System.Windows.Forms.Label 连接总数统计;


    private global::System.Windows.Forms.Label 已经登录统计;


    private global::System.Windows.Forms.Button 保存聊天日志;


    private global::System.Windows.Forms.Button 清空聊天日志;


    private global::System.Windows.Forms.TabControl 角色详情选项卡;


    private global::System.Windows.Forms.TabPage CharacterData_技能;


    private global::System.Windows.Forms.TabPage CharacterData_装备;


    private global::System.Windows.Forms.TabPage CharacterData_背包;


    private global::System.Windows.Forms.TabPage CharacterData_仓库;


    public global::System.Windows.Forms.TabControl 主选项卡;


    public global::System.Windows.Forms.DataGridView dgvCharacters;


    public global::System.Windows.Forms.DataGridView 技能浏览表;


    private global::System.Windows.Forms.DataGridView 装备浏览表;


    public global::System.Windows.Forms.DataGridView 背包浏览表;


    public global::System.Windows.Forms.DataGridView 仓库浏览表;


    private global::System.Windows.Forms.Timer 界面定时更新;


    private global::System.Windows.Forms.TabPage tabSystem;


    private global::System.Windows.Forms.TabPage tabChat;


    private global::System.Windows.Forms.RichTextBox 聊天日志;


    public global::System.Windows.Forms.DataGridView dgvMaps;


    public global::System.Windows.Forms.DataGridView 怪物浏览表;


    private global::System.Windows.Forms.DataGridView 掉落浏览表;


    private global::System.Windows.Forms.GroupBox S_网络设置分组;


    private global::System.Windows.Forms.Label S_监听端口标签;


    private global::System.Windows.Forms.NumericUpDown S_GSPort;


    private global::System.Windows.Forms.Label S_接收端口标签;


    private global::System.Windows.Forms.NumericUpDown S_TSPort;


    private global::System.Windows.Forms.Label L_AbnormalBlockTime;


    private global::System.Windows.Forms.NumericUpDown S_AbnormalBlockTime;


    private global::System.Windows.Forms.GroupBox S_游戏设置分组;


    private global::System.Windows.Forms.Label S_特修折扣标签;


    private global::System.Windows.Forms.NumericUpDown S_EquipRepairDto;


    private global::System.Windows.Forms.Label S_怪物爆率标签;


    private global::System.Windows.Forms.Label S_OpenLevelCommand标签;


    private global::System.Windows.Forms.Label S_限定封包标签;


    private global::System.Windows.Forms.NumericUpDown S_PacketLimit;


    private global::System.Windows.Forms.Label S_掉线判定标签;


    private global::System.Windows.Forms.NumericUpDown S_DisconnectTime;


    private global::System.Windows.Forms.Label S_经验倍率标签;


    private global::System.Windows.Forms.Label S_收益等级标签;


    private global::System.Windows.Forms.NumericUpDown S_LessExpGrade;


    private global::System.Windows.Forms.Label S_收益衰减标签;


    private global::System.Windows.Forms.NumericUpDown S_LessExpGradeRate;


    private global::System.Windows.Forms.Label S_诱惑时长标签;


    private global::System.Windows.Forms.NumericUpDown S_TemptationTime;


    private global::System.Windows.Forms.Label S_物品归属标签;


    private global::System.Windows.Forms.NumericUpDown S_ItemOwnershipTime;


    private global::System.Windows.Forms.Label S_物品清理标签;


    private global::System.Windows.Forms.NumericUpDown S_ItemCleaningTime;


    private global::System.Windows.Forms.GroupBox S_GameData分组;


    private global::System.Windows.Forms.TextBox S_数据备份目录;


    private global::System.Windows.Forms.TextBox S_GameData目录;


    private global::System.Windows.Forms.Label S_备份目录标签;


    private global::System.Windows.Forms.Label S_数据目录标签;


    private global::System.Windows.Forms.Button S_合并客户数据;


    private global::System.Windows.Forms.TextBox S_合并数据目录;


    private global::System.Windows.Forms.Label S_合并目录标签;


    private global::System.Windows.Forms.Button S_浏览数据目录;


    private global::System.Windows.Forms.Button S_浏览合并目录;


    private global::System.Windows.Forms.Button S_浏览备份目录;


    private global::System.Windows.Forms.Button S_重载SystemData;


    private global::System.Windows.Forms.TextBox GMCommand文本;


    private global::System.Windows.Forms.Label GMCommand标签;


    public global::System.Windows.Forms.Button 启动按钮;


    public global::System.Windows.Forms.Button 停止按钮;


    private global::System.Windows.Forms.Button S_重载客户数据;


    public global::System.Windows.Forms.Button 保存按钮;


    private global::System.Windows.Forms.Label 对象统计;


    private global::System.Windows.Forms.Label S_注意事项标签2;


    private global::System.Windows.Forms.Label S_注意事项标签1;


    private global::System.Windows.Forms.Label S_注意事项标签5;


    private global::System.Windows.Forms.Label S_注意事项标签4;


    private global::System.Windows.Forms.Label S_注意事项标签3;


    private global::System.Windows.Forms.Label S_注意事项标签6;


    private global::System.Windows.Forms.Label S_注意事项标签8;


    private global::System.Windows.Forms.Label S_注意事项标签7;


    private global::System.Windows.Forms.TabPage tabCommands;


    private global::System.Windows.Forms.RichTextBox 命令日志;


    private global::System.Windows.Forms.Button 清空命令日志;


    private global::System.Windows.Forms.Timer 保存数据提醒;


    public global::System.Windows.Forms.TabPage tabConfig;


    public global::System.Windows.Forms.Panel 下方控件页;


    private global::System.Windows.Forms.ContextMenuStrip 角色右键菜单;


    private global::System.Windows.Forms.ToolStripMenuItem 右键菜单_复制CharName;


    private global::System.Windows.Forms.ToolStripMenuItem 右键菜单_复制Account;


    private global::System.Windows.Forms.ToolStripMenuItem 右键菜单_复制网络地址;


    private global::System.Windows.Forms.ToolStripMenuItem 右键菜单_复制物理地址;


    public global::System.Windows.Forms.TabPage tabBans;


    private global::System.Windows.Forms.TabPage tabAnnouncements;


    public global::System.Windows.Forms.TabPage tabMain;


    public global::System.Windows.Forms.TabPage tabMaps;


    public global::System.Windows.Forms.TabPage tabMonsters;


    public global::System.Windows.Forms.TabPage tabCharacters;


    private global::System.Windows.Forms.DataGridView 封禁浏览表;


    public global::System.Windows.Forms.NumericUpDown S_ExtraDropRate;


    public global::System.Windows.Forms.NumericUpDown S_ExpRate;


    public global::System.Windows.Forms.NumericUpDown S_MaxLevel;


    private global::System.Windows.Forms.Button 删除公告按钮;


    private global::System.Windows.Forms.Button 添加公告按钮;


    public global::System.Windows.Forms.Timer 定时发送公告;


    public global::System.Windows.Forms.DataGridView 公告浏览表;


    public global::System.Windows.Forms.Button 开始公告按钮;


    public global::System.Windows.Forms.Button 停止公告按钮;








    private global::System.Windows.Forms.Label L_NoobLevel;


    public global::System.Windows.Forms.NumericUpDown S_NoobLevel;


    public global::System.Windows.Forms.TabControl MainTabs;


    private global::System.Windows.Forms.GroupBox S_软件授权分组;


    private global::System.Windows.Forms.TextBox S_软件注册代码;
    private System.Windows.Forms.TabPage tabPackets;
    private System.Windows.Forms.RichTextBox rtbPacketsLogs;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
    private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    private System.Windows.Forms.DataGridViewTextBoxColumn RemainingTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    private System.Windows.Forms.DataGridViewTextBoxColumn Content;
    private System.Windows.Forms.Button 重载数据;
  }
}
