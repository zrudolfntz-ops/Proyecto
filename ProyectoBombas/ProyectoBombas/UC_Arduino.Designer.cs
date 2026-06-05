namespace ProyectoBombas
{
    partial class UC_Arduino
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            SiticoneNetCoreUI.SiticoneLabel lblTitulo;
            grpArduino1 = new SiticoneNetCoreUI.SiticoneGroupBox();
            lblEstadoArduino1 = new SiticoneNetCoreUI.SiticoneLabel();
            btnDesconectarArduino1 = new SiticoneNetCoreUI.SiticoneButton();
            btnConectarArduino1 = new SiticoneNetCoreUI.SiticoneButton();
            cmbPuertoArduino1 = new SiticoneNetCoreUI.SiticoneDropdown();
            lblPuerto1 = new SiticoneNetCoreUI.SiticoneLabel();
            siticonePanel1 = new SiticoneNetCoreUI.SiticonePanel();
            rtbEventos = new RichTextBox();
            lblEventos = new SiticoneNetCoreUI.SiticoneLabel();
            btnActualizarPuertos = new SiticoneNetCoreUI.SiticoneButton();
            grpArduino2 = new SiticoneNetCoreUI.SiticoneGroupBox();
            lblEstadoArduino2 = new SiticoneNetCoreUI.SiticoneLabel();
            btnDesconectarArduino2 = new SiticoneNetCoreUI.SiticoneButton();
            btnConectarArduino2 = new SiticoneNetCoreUI.SiticoneButton();
            cmbPuertoArduino2 = new SiticoneNetCoreUI.SiticoneDropdown();
            lblPuertoArduino2 = new SiticoneNetCoreUI.SiticoneLabel();
            lblTitulo = new SiticoneNetCoreUI.SiticoneLabel();
            grpArduino1.SuspendLayout();
            siticonePanel1.SuspendLayout();
            grpArduino2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Arial Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(226, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(950, 136);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Configuración de Arduinos";
            // 
            // grpArduino1
            // 
            grpArduino1.BackColor = Color.Transparent;
            grpArduino1.BadgeColor = Color.Red;
            grpArduino1.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            grpArduino1.BadgeLeftPadding = 12;
            grpArduino1.BadgeValue = 0;
            grpArduino1.BadgeVisible = false;
            grpArduino1.BlinkInterval = 500;
            grpArduino1.BlinkMinOpacity = 0.3F;
            grpArduino1.BlinkOpacityStep = 0.05F;
            grpArduino1.BorderColor = Color.FromArgb(220, 222, 224);
            grpArduino1.BorderWidth = 1F;
            grpArduino1.ChevronColor = Color.FromArgb(90, 90, 90);
            grpArduino1.ChevronLeftSpacing = 4F;
            grpArduino1.ChevronSize = 10F;
            grpArduino1.ChevronThickness = 2F;
            grpArduino1.ContentPadding = 5;
            grpArduino1.Controls.Add(lblEstadoArduino1);
            grpArduino1.Controls.Add(btnDesconectarArduino1);
            grpArduino1.Controls.Add(btnConectarArduino1);
            grpArduino1.Controls.Add(cmbPuertoArduino1);
            grpArduino1.Controls.Add(lblPuerto1);
            grpArduino1.CornerRadius = 8;
            grpArduino1.EnableBlinking = false;
            grpArduino1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpArduino1.GradientEndColor = Color.LightGray;
            grpArduino1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            grpArduino1.GradientStartColor = Color.White;
            grpArduino1.GroupTitle = "GroupBox";
            grpArduino1.HoveredBorderColor = Color.FromArgb(0, 120, 215);
            grpArduino1.HoveredTitleColor = Color.FromArgb(0, 120, 215);
            grpArduino1.Location = new Point(126, 234);
            grpArduino1.MaxBlinkCount = 3;
            grpArduino1.Name = "grpArduino1";
            grpArduino1.PressedBorderColor = Color.FromArgb(0, 84, 153);
            grpArduino1.ShadowColor = Color.FromArgb(20, 0, 0, 0);
            grpArduino1.ShadowDepth = 4;
            grpArduino1.ShowShadow = true;
            grpArduino1.Size = new Size(576, 647);
            grpArduino1.SolidFillColor = Color.FromArgb(249, 249, 249);
            grpArduino1.StatusIcon = null;
            grpArduino1.StatusText = "";
            grpArduino1.TabIndex = 2;
            grpArduino1.Text = "Arduino 1";
            grpArduino1.TitleBackColor = Color.Transparent;
            grpArduino1.TitleColor = Color.FromArgb(30, 30, 30);
            grpArduino1.TitlePadding = new Padding(10, 8, 10, 12);
            grpArduino1.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            grpArduino1.UseGradient = false;
            // 
            // lblEstadoArduino1
            // 
            lblEstadoArduino1.Font = new Font("Segoe UI", 10F);
            lblEstadoArduino1.Location = new Point(32, 490);
            lblEstadoArduino1.Name = "lblEstadoArduino1";
            lblEstadoArduino1.Size = new Size(458, 46);
            lblEstadoArduino1.TabIndex = 4;
            lblEstadoArduino1.Text = "Estado: Desconectado";
            // 
            // btnDesconectarArduino1
            // 
            btnDesconectarArduino1.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnDesconectarArduino1.AccessibleName = "Desconectar";
            btnDesconectarArduino1.AutoSizeBasedOnText = false;
            btnDesconectarArduino1.BackColor = Color.Transparent;
            btnDesconectarArduino1.BadgeBackColor = Color.Black;
            btnDesconectarArduino1.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDesconectarArduino1.BadgeValue = 0;
            btnDesconectarArduino1.BadgeValueForeColor = Color.White;
            btnDesconectarArduino1.BorderColor = Color.FromArgb(213, 216, 220);
            btnDesconectarArduino1.BorderWidth = 1;
            btnDesconectarArduino1.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnDesconectarArduino1.ButtonImage = null;
            btnDesconectarArduino1.ButtonTextLeftPadding = 0;
            btnDesconectarArduino1.CanBeep = true;
            btnDesconectarArduino1.CanGlow = false;
            btnDesconectarArduino1.CanShake = true;
            btnDesconectarArduino1.ContextMenuStripEx = null;
            btnDesconectarArduino1.CornerRadiusBottomLeft = 6;
            btnDesconectarArduino1.CornerRadiusBottomRight = 6;
            btnDesconectarArduino1.CornerRadiusTopLeft = 6;
            btnDesconectarArduino1.CornerRadiusTopRight = 6;
            btnDesconectarArduino1.CustomCursor = Cursors.Default;
            btnDesconectarArduino1.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnDesconectarArduino1.EnableLongPress = false;
            btnDesconectarArduino1.EnableRippleEffect = true;
            btnDesconectarArduino1.EnableShadow = false;
            btnDesconectarArduino1.EnableTextWrapping = false;
            btnDesconectarArduino1.Font = new Font("Segoe UI Semibold", 10.2F);
            btnDesconectarArduino1.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnDesconectarArduino1.GlowIntensity = 100;
            btnDesconectarArduino1.GlowRadius = 20F;
            btnDesconectarArduino1.GradientBackground = false;
            btnDesconectarArduino1.GradientColor = Color.FromArgb(0, 227, 64);
            btnDesconectarArduino1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnDesconectarArduino1.HintText = null;
            btnDesconectarArduino1.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnDesconectarArduino1.HoverFontStyle = FontStyle.Regular;
            btnDesconectarArduino1.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnDesconectarArduino1.HoverTransitionDuration = 140;
            btnDesconectarArduino1.ImageAlign = ContentAlignment.MiddleLeft;
            btnDesconectarArduino1.ImagePadding = 5;
            btnDesconectarArduino1.ImageSize = new Size(16, 16);
            btnDesconectarArduino1.IsRadial = false;
            btnDesconectarArduino1.IsReadOnly = false;
            btnDesconectarArduino1.IsToggleButton = false;
            btnDesconectarArduino1.IsToggled = false;
            btnDesconectarArduino1.Location = new Point(58, 356);
            btnDesconectarArduino1.LongPressDurationMS = 1000;
            btnDesconectarArduino1.Name = "btnDesconectarArduino1";
            btnDesconectarArduino1.NormalFontStyle = FontStyle.Regular;
            btnDesconectarArduino1.ParticleColor = Color.FromArgb(200, 200, 200);
            btnDesconectarArduino1.ParticleCount = 15;
            btnDesconectarArduino1.PressAnimationScale = 0.97F;
            btnDesconectarArduino1.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnDesconectarArduino1.PressedFontStyle = FontStyle.Regular;
            btnDesconectarArduino1.PressTransitionDuration = 90;
            btnDesconectarArduino1.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnDesconectarArduino1.RippleColor = Color.FromArgb(0, 0, 0);
            btnDesconectarArduino1.RippleRadiusMultiplier = 0.6F;
            btnDesconectarArduino1.ShadowBlur = 5;
            btnDesconectarArduino1.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnDesconectarArduino1.ShadowOffset = new Point(0, 2);
            btnDesconectarArduino1.ShakeDuration = 500;
            btnDesconectarArduino1.ShakeIntensity = 5;
            btnDesconectarArduino1.Size = new Size(380, 100);
            btnDesconectarArduino1.TabIndex = 3;
            btnDesconectarArduino1.Text = "Desconectar";
            btnDesconectarArduino1.TextAlign = ContentAlignment.MiddleCenter;
            btnDesconectarArduino1.TextColor = Color.FromArgb(0, 0, 0);
            btnDesconectarArduino1.TooltipText = null;
            btnDesconectarArduino1.UseAdvancedRendering = true;
            btnDesconectarArduino1.UseParticles = false;
            // 
            // btnConectarArduino1
            // 
            btnConectarArduino1.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnConectarArduino1.AccessibleName = "Conectar";
            btnConectarArduino1.AutoSizeBasedOnText = false;
            btnConectarArduino1.BackColor = Color.Transparent;
            btnConectarArduino1.BadgeBackColor = Color.Black;
            btnConectarArduino1.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnConectarArduino1.BadgeValue = 0;
            btnConectarArduino1.BadgeValueForeColor = Color.White;
            btnConectarArduino1.BorderColor = Color.FromArgb(213, 216, 220);
            btnConectarArduino1.BorderWidth = 1;
            btnConectarArduino1.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnConectarArduino1.ButtonImage = null;
            btnConectarArduino1.ButtonTextLeftPadding = 0;
            btnConectarArduino1.CanBeep = true;
            btnConectarArduino1.CanGlow = false;
            btnConectarArduino1.CanShake = true;
            btnConectarArduino1.ContextMenuStripEx = null;
            btnConectarArduino1.CornerRadiusBottomLeft = 6;
            btnConectarArduino1.CornerRadiusBottomRight = 6;
            btnConectarArduino1.CornerRadiusTopLeft = 6;
            btnConectarArduino1.CornerRadiusTopRight = 6;
            btnConectarArduino1.CustomCursor = Cursors.Default;
            btnConectarArduino1.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnConectarArduino1.EnableLongPress = false;
            btnConectarArduino1.EnableRippleEffect = true;
            btnConectarArduino1.EnableShadow = false;
            btnConectarArduino1.EnableTextWrapping = false;
            btnConectarArduino1.Font = new Font("Segoe UI Semibold", 10.2F);
            btnConectarArduino1.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnConectarArduino1.GlowIntensity = 100;
            btnConectarArduino1.GlowRadius = 20F;
            btnConectarArduino1.GradientBackground = false;
            btnConectarArduino1.GradientColor = Color.FromArgb(0, 227, 64);
            btnConectarArduino1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnConectarArduino1.HintText = null;
            btnConectarArduino1.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnConectarArduino1.HoverFontStyle = FontStyle.Regular;
            btnConectarArduino1.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnConectarArduino1.HoverTransitionDuration = 140;
            btnConectarArduino1.ImageAlign = ContentAlignment.MiddleLeft;
            btnConectarArduino1.ImagePadding = 5;
            btnConectarArduino1.ImageSize = new Size(16, 16);
            btnConectarArduino1.IsRadial = false;
            btnConectarArduino1.IsReadOnly = false;
            btnConectarArduino1.IsToggleButton = false;
            btnConectarArduino1.IsToggled = false;
            btnConectarArduino1.Location = new Point(58, 234);
            btnConectarArduino1.LongPressDurationMS = 1000;
            btnConectarArduino1.Name = "btnConectarArduino1";
            btnConectarArduino1.NormalFontStyle = FontStyle.Regular;
            btnConectarArduino1.ParticleColor = Color.FromArgb(200, 200, 200);
            btnConectarArduino1.ParticleCount = 15;
            btnConectarArduino1.PressAnimationScale = 0.97F;
            btnConectarArduino1.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnConectarArduino1.PressedFontStyle = FontStyle.Regular;
            btnConectarArduino1.PressTransitionDuration = 90;
            btnConectarArduino1.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnConectarArduino1.RippleColor = Color.FromArgb(0, 0, 0);
            btnConectarArduino1.RippleRadiusMultiplier = 0.6F;
            btnConectarArduino1.ShadowBlur = 5;
            btnConectarArduino1.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnConectarArduino1.ShadowOffset = new Point(0, 2);
            btnConectarArduino1.ShakeDuration = 500;
            btnConectarArduino1.ShakeIntensity = 5;
            btnConectarArduino1.Size = new Size(380, 100);
            btnConectarArduino1.TabIndex = 2;
            btnConectarArduino1.Text = "Conectar";
            btnConectarArduino1.TextAlign = ContentAlignment.MiddleCenter;
            btnConectarArduino1.TextColor = Color.FromArgb(0, 0, 0);
            btnConectarArduino1.TooltipText = null;
            btnConectarArduino1.UseAdvancedRendering = true;
            btnConectarArduino1.UseParticles = false;
            // 
            // cmbPuertoArduino1
            // 
            cmbPuertoArduino1.AllowMultipleSelection = false;
            cmbPuertoArduino1.BackColor = Color.FromArgb(235, 235, 235);
            cmbPuertoArduino1.BorderColor = Color.FromArgb(200, 200, 200);
            cmbPuertoArduino1.CanBeep = false;
            cmbPuertoArduino1.CanShake = true;
            cmbPuertoArduino1.DataSource = null;
            cmbPuertoArduino1.DisplayMember = null;
            cmbPuertoArduino1.DropdownBackColor = Color.FromArgb(245, 245, 245);
            cmbPuertoArduino1.DropdownWidth = 0;
            cmbPuertoArduino1.DropShadowEnabled = false;
            cmbPuertoArduino1.Font = new Font("Segoe UI", 10F);
            cmbPuertoArduino1.ForeColor = Color.FromArgb(30, 30, 30);
            cmbPuertoArduino1.HoveredItemBackColor = Color.FromArgb(210, 210, 210);
            cmbPuertoArduino1.HoveredItemTextColor = Color.Black;
            cmbPuertoArduino1.IsReadonly = false;
            cmbPuertoArduino1.ItemHeight = 30;
            cmbPuertoArduino1.Location = new Point(32, 136);
            cmbPuertoArduino1.MaxDropDownItems = 8;
            cmbPuertoArduino1.Name = "cmbPuertoArduino1";
            cmbPuertoArduino1.NotFoundBackColor = Color.Transparent;
            cmbPuertoArduino1.NotFoundFont = null;
            cmbPuertoArduino1.NotFoundTextColor = Color.Gray;
            cmbPuertoArduino1.PlaceholderColor = Color.FromArgb(140, 140, 140);
            cmbPuertoArduino1.PlaceholderDisappearsOnFocus = false;
            cmbPuertoArduino1.PlaceholderText = "Select an option";
            cmbPuertoArduino1.SearchTextColor = Color.Black;
            cmbPuertoArduino1.SearchTextFont = null;
            cmbPuertoArduino1.SelectedIndex = -1;
            cmbPuertoArduino1.SelectedItem = null;
            cmbPuertoArduino1.SelectedItemBackColor = Color.FromArgb(50, 50, 50);
            cmbPuertoArduino1.SelectedItemTextColor = Color.White;
            cmbPuertoArduino1.SelectedValue = null;
            cmbPuertoArduino1.Size = new Size(440, 80);
            cmbPuertoArduino1.TabIndex = 1;
            cmbPuertoArduino1.Text = "siticoneDropdown1";
            cmbPuertoArduino1.UnselectedItemTextColor = Color.FromArgb(30, 30, 30);
            cmbPuertoArduino1.ValueMember = null;
            // 
            // lblPuerto1
            // 
            lblPuerto1.Font = new Font("Segoe UI", 10F);
            lblPuerto1.Location = new Point(22, 66);
            lblPuerto1.Name = "lblPuerto1";
            lblPuerto1.Size = new Size(200, 46);
            lblPuerto1.TabIndex = 0;
            lblPuerto1.Text = "Puerto COM";
            // 
            // siticonePanel1
            // 
            siticonePanel1.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel1.BackColor = Color.Transparent;
            siticonePanel1.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            siticonePanel1.BorderColor = Color.Gray;
            siticonePanel1.BorderDashPattern = null;
            siticonePanel1.BorderGradientEndColor = Color.Purple;
            siticonePanel1.BorderGradientStartColor = Color.Blue;
            siticonePanel1.BorderThickness = 2F;
            siticonePanel1.Controls.Add(rtbEventos);
            siticonePanel1.Controls.Add(lblEventos);
            siticonePanel1.Controls.Add(btnActualizarPuertos);
            siticonePanel1.Controls.Add(grpArduino2);
            siticonePanel1.Controls.Add(lblTitulo);
            siticonePanel1.Controls.Add(grpArduino1);
            siticonePanel1.CornerRadiusBottomLeft = 0F;
            siticonePanel1.CornerRadiusBottomRight = 0F;
            siticonePanel1.CornerRadiusTopLeft = 0F;
            siticonePanel1.CornerRadiusTopRight = 0F;
            siticonePanel1.Dock = DockStyle.Fill;
            siticonePanel1.EnableAcrylicEffect = false;
            siticonePanel1.EnableMicaEffect = false;
            siticonePanel1.EnableRippleEffect = false;
            siticonePanel1.FillColor = Color.White;
            siticonePanel1.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            siticonePanel1.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            siticonePanel1.Location = new Point(0, 0);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = true;
            siticonePanel1.Size = new Size(1530, 1548);
            siticonePanel1.TabIndex = 3;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            // 
            // rtbEventos
            // 
            rtbEventos.Location = new Point(462, 1152);
            rtbEventos.Name = "rtbEventos";
            rtbEventos.ReadOnly = true;
            rtbEventos.Size = new Size(490, 314);
            rtbEventos.TabIndex = 8;
            rtbEventos.Text = "";
            // 
            // lblEventos
            // 
            lblEventos.Font = new Font("Segoe UI", 10F);
            lblEventos.Location = new Point(588, 1078);
            lblEventos.Name = "lblEventos";
            lblEventos.Size = new Size(270, 46);
            lblEventos.TabIndex = 7;
            lblEventos.Text = "Eventos del Sistema";
            // 
            // btnActualizarPuertos
            // 
            btnActualizarPuertos.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnActualizarPuertos.AccessibleName = "Actualizar Puertos";
            btnActualizarPuertos.AutoSizeBasedOnText = false;
            btnActualizarPuertos.BackColor = Color.Transparent;
            btnActualizarPuertos.BadgeBackColor = Color.Black;
            btnActualizarPuertos.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnActualizarPuertos.BadgeValue = 0;
            btnActualizarPuertos.BadgeValueForeColor = Color.White;
            btnActualizarPuertos.BorderColor = Color.FromArgb(213, 216, 220);
            btnActualizarPuertos.BorderWidth = 1;
            btnActualizarPuertos.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnActualizarPuertos.ButtonImage = null;
            btnActualizarPuertos.ButtonTextLeftPadding = 0;
            btnActualizarPuertos.CanBeep = true;
            btnActualizarPuertos.CanGlow = false;
            btnActualizarPuertos.CanShake = true;
            btnActualizarPuertos.ContextMenuStripEx = null;
            btnActualizarPuertos.CornerRadiusBottomLeft = 6;
            btnActualizarPuertos.CornerRadiusBottomRight = 6;
            btnActualizarPuertos.CornerRadiusTopLeft = 6;
            btnActualizarPuertos.CornerRadiusTopRight = 6;
            btnActualizarPuertos.CustomCursor = Cursors.Default;
            btnActualizarPuertos.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnActualizarPuertos.EnableLongPress = false;
            btnActualizarPuertos.EnableRippleEffect = true;
            btnActualizarPuertos.EnableShadow = false;
            btnActualizarPuertos.EnableTextWrapping = false;
            btnActualizarPuertos.Font = new Font("Segoe UI Semibold", 10.2F);
            btnActualizarPuertos.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnActualizarPuertos.GlowIntensity = 100;
            btnActualizarPuertos.GlowRadius = 20F;
            btnActualizarPuertos.GradientBackground = false;
            btnActualizarPuertos.GradientColor = Color.FromArgb(0, 227, 64);
            btnActualizarPuertos.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnActualizarPuertos.HintText = null;
            btnActualizarPuertos.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnActualizarPuertos.HoverFontStyle = FontStyle.Regular;
            btnActualizarPuertos.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnActualizarPuertos.HoverTransitionDuration = 140;
            btnActualizarPuertos.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizarPuertos.ImagePadding = 5;
            btnActualizarPuertos.ImageSize = new Size(16, 16);
            btnActualizarPuertos.IsRadial = false;
            btnActualizarPuertos.IsReadOnly = false;
            btnActualizarPuertos.IsToggleButton = false;
            btnActualizarPuertos.IsToggled = false;
            btnActualizarPuertos.Location = new Point(528, 962);
            btnActualizarPuertos.LongPressDurationMS = 1000;
            btnActualizarPuertos.Name = "btnActualizarPuertos";
            btnActualizarPuertos.NormalFontStyle = FontStyle.Regular;
            btnActualizarPuertos.ParticleColor = Color.FromArgb(200, 200, 200);
            btnActualizarPuertos.ParticleCount = 15;
            btnActualizarPuertos.PressAnimationScale = 0.97F;
            btnActualizarPuertos.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnActualizarPuertos.PressedFontStyle = FontStyle.Regular;
            btnActualizarPuertos.PressTransitionDuration = 90;
            btnActualizarPuertos.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnActualizarPuertos.RippleColor = Color.FromArgb(0, 0, 0);
            btnActualizarPuertos.RippleRadiusMultiplier = 0.6F;
            btnActualizarPuertos.ShadowBlur = 5;
            btnActualizarPuertos.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnActualizarPuertos.ShadowOffset = new Point(0, 2);
            btnActualizarPuertos.ShakeDuration = 500;
            btnActualizarPuertos.ShakeIntensity = 5;
            btnActualizarPuertos.Size = new Size(380, 100);
            btnActualizarPuertos.TabIndex = 6;
            btnActualizarPuertos.Text = "Actualizar Puertos";
            btnActualizarPuertos.TextAlign = ContentAlignment.MiddleCenter;
            btnActualizarPuertos.TextColor = Color.FromArgb(0, 0, 0);
            btnActualizarPuertos.TooltipText = null;
            btnActualizarPuertos.UseAdvancedRendering = true;
            btnActualizarPuertos.UseParticles = false;
            btnActualizarPuertos.Click += btnActualizarPuertos_Click;
            // 
            // grpArduino2
            // 
            grpArduino2.BackColor = Color.Transparent;
            grpArduino2.BadgeColor = Color.Red;
            grpArduino2.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            grpArduino2.BadgeLeftPadding = 12;
            grpArduino2.BadgeValue = 0;
            grpArduino2.BadgeVisible = false;
            grpArduino2.BlinkInterval = 500;
            grpArduino2.BlinkMinOpacity = 0.3F;
            grpArduino2.BlinkOpacityStep = 0.05F;
            grpArduino2.BorderColor = Color.FromArgb(220, 222, 224);
            grpArduino2.BorderWidth = 1F;
            grpArduino2.ChevronColor = Color.FromArgb(90, 90, 90);
            grpArduino2.ChevronLeftSpacing = 4F;
            grpArduino2.ChevronSize = 10F;
            grpArduino2.ChevronThickness = 2F;
            grpArduino2.ContentPadding = 5;
            grpArduino2.Controls.Add(lblEstadoArduino2);
            grpArduino2.Controls.Add(btnDesconectarArduino2);
            grpArduino2.Controls.Add(btnConectarArduino2);
            grpArduino2.Controls.Add(cmbPuertoArduino2);
            grpArduino2.Controls.Add(lblPuertoArduino2);
            grpArduino2.CornerRadius = 8;
            grpArduino2.EnableBlinking = false;
            grpArduino2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpArduino2.GradientEndColor = Color.LightGray;
            grpArduino2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            grpArduino2.GradientStartColor = Color.White;
            grpArduino2.GroupTitle = "GroupBox";
            grpArduino2.HoveredBorderColor = Color.FromArgb(0, 120, 215);
            grpArduino2.HoveredTitleColor = Color.FromArgb(0, 120, 215);
            grpArduino2.Location = new Point(780, 234);
            grpArduino2.MaxBlinkCount = 3;
            grpArduino2.Name = "grpArduino2";
            grpArduino2.PressedBorderColor = Color.FromArgb(0, 84, 153);
            grpArduino2.ShadowColor = Color.FromArgb(20, 0, 0, 0);
            grpArduino2.ShadowDepth = 4;
            grpArduino2.ShowShadow = true;
            grpArduino2.Size = new Size(576, 647);
            grpArduino2.SolidFillColor = Color.FromArgb(249, 249, 249);
            grpArduino2.StatusIcon = null;
            grpArduino2.StatusText = "";
            grpArduino2.TabIndex = 5;
            grpArduino2.Text = "Arduino 2";
            grpArduino2.TitleBackColor = Color.Transparent;
            grpArduino2.TitleColor = Color.FromArgb(30, 30, 30);
            grpArduino2.TitlePadding = new Padding(10, 8, 10, 12);
            grpArduino2.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            grpArduino2.UseGradient = false;
            // 
            // lblEstadoArduino2
            // 
            lblEstadoArduino2.Font = new Font("Segoe UI", 10F);
            lblEstadoArduino2.Location = new Point(32, 490);
            lblEstadoArduino2.Name = "lblEstadoArduino2";
            lblEstadoArduino2.Size = new Size(458, 46);
            lblEstadoArduino2.TabIndex = 4;
            lblEstadoArduino2.Text = "Estado: Desconectado";
            // 
            // btnDesconectarArduino2
            // 
            btnDesconectarArduino2.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnDesconectarArduino2.AccessibleName = "Desconectar";
            btnDesconectarArduino2.AutoSizeBasedOnText = false;
            btnDesconectarArduino2.BackColor = Color.Transparent;
            btnDesconectarArduino2.BadgeBackColor = Color.Black;
            btnDesconectarArduino2.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDesconectarArduino2.BadgeValue = 0;
            btnDesconectarArduino2.BadgeValueForeColor = Color.White;
            btnDesconectarArduino2.BorderColor = Color.FromArgb(213, 216, 220);
            btnDesconectarArduino2.BorderWidth = 1;
            btnDesconectarArduino2.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnDesconectarArduino2.ButtonImage = null;
            btnDesconectarArduino2.ButtonTextLeftPadding = 0;
            btnDesconectarArduino2.CanBeep = true;
            btnDesconectarArduino2.CanGlow = false;
            btnDesconectarArduino2.CanShake = true;
            btnDesconectarArduino2.ContextMenuStripEx = null;
            btnDesconectarArduino2.CornerRadiusBottomLeft = 6;
            btnDesconectarArduino2.CornerRadiusBottomRight = 6;
            btnDesconectarArduino2.CornerRadiusTopLeft = 6;
            btnDesconectarArduino2.CornerRadiusTopRight = 6;
            btnDesconectarArduino2.CustomCursor = Cursors.Default;
            btnDesconectarArduino2.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnDesconectarArduino2.EnableLongPress = false;
            btnDesconectarArduino2.EnableRippleEffect = true;
            btnDesconectarArduino2.EnableShadow = false;
            btnDesconectarArduino2.EnableTextWrapping = false;
            btnDesconectarArduino2.Font = new Font("Segoe UI Semibold", 10.2F);
            btnDesconectarArduino2.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnDesconectarArduino2.GlowIntensity = 100;
            btnDesconectarArduino2.GlowRadius = 20F;
            btnDesconectarArduino2.GradientBackground = false;
            btnDesconectarArduino2.GradientColor = Color.FromArgb(0, 227, 64);
            btnDesconectarArduino2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnDesconectarArduino2.HintText = null;
            btnDesconectarArduino2.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnDesconectarArduino2.HoverFontStyle = FontStyle.Regular;
            btnDesconectarArduino2.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnDesconectarArduino2.HoverTransitionDuration = 140;
            btnDesconectarArduino2.ImageAlign = ContentAlignment.MiddleLeft;
            btnDesconectarArduino2.ImagePadding = 5;
            btnDesconectarArduino2.ImageSize = new Size(16, 16);
            btnDesconectarArduino2.IsRadial = false;
            btnDesconectarArduino2.IsReadOnly = false;
            btnDesconectarArduino2.IsToggleButton = false;
            btnDesconectarArduino2.IsToggled = false;
            btnDesconectarArduino2.Location = new Point(58, 356);
            btnDesconectarArduino2.LongPressDurationMS = 1000;
            btnDesconectarArduino2.Name = "btnDesconectarArduino2";
            btnDesconectarArduino2.NormalFontStyle = FontStyle.Regular;
            btnDesconectarArduino2.ParticleColor = Color.FromArgb(200, 200, 200);
            btnDesconectarArduino2.ParticleCount = 15;
            btnDesconectarArduino2.PressAnimationScale = 0.97F;
            btnDesconectarArduino2.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnDesconectarArduino2.PressedFontStyle = FontStyle.Regular;
            btnDesconectarArduino2.PressTransitionDuration = 90;
            btnDesconectarArduino2.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnDesconectarArduino2.RippleColor = Color.FromArgb(0, 0, 0);
            btnDesconectarArduino2.RippleRadiusMultiplier = 0.6F;
            btnDesconectarArduino2.ShadowBlur = 5;
            btnDesconectarArduino2.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnDesconectarArduino2.ShadowOffset = new Point(0, 2);
            btnDesconectarArduino2.ShakeDuration = 500;
            btnDesconectarArduino2.ShakeIntensity = 5;
            btnDesconectarArduino2.Size = new Size(380, 100);
            btnDesconectarArduino2.TabIndex = 3;
            btnDesconectarArduino2.Text = "Desconectar";
            btnDesconectarArduino2.TextAlign = ContentAlignment.MiddleCenter;
            btnDesconectarArduino2.TextColor = Color.FromArgb(0, 0, 0);
            btnDesconectarArduino2.TooltipText = null;
            btnDesconectarArduino2.UseAdvancedRendering = true;
            btnDesconectarArduino2.UseParticles = false;
            // 
            // btnConectarArduino2
            // 
            btnConectarArduino2.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnConectarArduino2.AccessibleName = "Conectar";
            btnConectarArduino2.AutoSizeBasedOnText = false;
            btnConectarArduino2.BackColor = Color.Transparent;
            btnConectarArduino2.BadgeBackColor = Color.Black;
            btnConectarArduino2.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnConectarArduino2.BadgeValue = 0;
            btnConectarArduino2.BadgeValueForeColor = Color.White;
            btnConectarArduino2.BorderColor = Color.FromArgb(213, 216, 220);
            btnConectarArduino2.BorderWidth = 1;
            btnConectarArduino2.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnConectarArduino2.ButtonImage = null;
            btnConectarArduino2.ButtonTextLeftPadding = 0;
            btnConectarArduino2.CanBeep = true;
            btnConectarArduino2.CanGlow = false;
            btnConectarArduino2.CanShake = true;
            btnConectarArduino2.ContextMenuStripEx = null;
            btnConectarArduino2.CornerRadiusBottomLeft = 6;
            btnConectarArduino2.CornerRadiusBottomRight = 6;
            btnConectarArduino2.CornerRadiusTopLeft = 6;
            btnConectarArduino2.CornerRadiusTopRight = 6;
            btnConectarArduino2.CustomCursor = Cursors.Default;
            btnConectarArduino2.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnConectarArduino2.EnableLongPress = false;
            btnConectarArduino2.EnableRippleEffect = true;
            btnConectarArduino2.EnableShadow = false;
            btnConectarArduino2.EnableTextWrapping = false;
            btnConectarArduino2.Font = new Font("Segoe UI Semibold", 10.2F);
            btnConectarArduino2.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnConectarArduino2.GlowIntensity = 100;
            btnConectarArduino2.GlowRadius = 20F;
            btnConectarArduino2.GradientBackground = false;
            btnConectarArduino2.GradientColor = Color.FromArgb(0, 227, 64);
            btnConectarArduino2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnConectarArduino2.HintText = null;
            btnConectarArduino2.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnConectarArduino2.HoverFontStyle = FontStyle.Regular;
            btnConectarArduino2.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnConectarArduino2.HoverTransitionDuration = 140;
            btnConectarArduino2.ImageAlign = ContentAlignment.MiddleLeft;
            btnConectarArduino2.ImagePadding = 5;
            btnConectarArduino2.ImageSize = new Size(16, 16);
            btnConectarArduino2.IsRadial = false;
            btnConectarArduino2.IsReadOnly = false;
            btnConectarArduino2.IsToggleButton = false;
            btnConectarArduino2.IsToggled = false;
            btnConectarArduino2.Location = new Point(58, 234);
            btnConectarArduino2.LongPressDurationMS = 1000;
            btnConectarArduino2.Name = "btnConectarArduino2";
            btnConectarArduino2.NormalFontStyle = FontStyle.Regular;
            btnConectarArduino2.ParticleColor = Color.FromArgb(200, 200, 200);
            btnConectarArduino2.ParticleCount = 15;
            btnConectarArduino2.PressAnimationScale = 0.97F;
            btnConectarArduino2.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnConectarArduino2.PressedFontStyle = FontStyle.Regular;
            btnConectarArduino2.PressTransitionDuration = 90;
            btnConectarArduino2.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnConectarArduino2.RippleColor = Color.FromArgb(0, 0, 0);
            btnConectarArduino2.RippleRadiusMultiplier = 0.6F;
            btnConectarArduino2.ShadowBlur = 5;
            btnConectarArduino2.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnConectarArduino2.ShadowOffset = new Point(0, 2);
            btnConectarArduino2.ShakeDuration = 500;
            btnConectarArduino2.ShakeIntensity = 5;
            btnConectarArduino2.Size = new Size(380, 100);
            btnConectarArduino2.TabIndex = 2;
            btnConectarArduino2.Text = "Conectar";
            btnConectarArduino2.TextAlign = ContentAlignment.MiddleCenter;
            btnConectarArduino2.TextColor = Color.FromArgb(0, 0, 0);
            btnConectarArduino2.TooltipText = null;
            btnConectarArduino2.UseAdvancedRendering = true;
            btnConectarArduino2.UseParticles = false;
            // 
            // cmbPuertoArduino2
            // 
            cmbPuertoArduino2.AllowMultipleSelection = false;
            cmbPuertoArduino2.BackColor = Color.FromArgb(235, 235, 235);
            cmbPuertoArduino2.BorderColor = Color.FromArgb(200, 200, 200);
            cmbPuertoArduino2.CanBeep = false;
            cmbPuertoArduino2.CanShake = true;
            cmbPuertoArduino2.DataSource = null;
            cmbPuertoArduino2.DisplayMember = null;
            cmbPuertoArduino2.DropdownBackColor = Color.FromArgb(245, 245, 245);
            cmbPuertoArduino2.DropdownWidth = 0;
            cmbPuertoArduino2.DropShadowEnabled = false;
            cmbPuertoArduino2.Font = new Font("Segoe UI", 10F);
            cmbPuertoArduino2.ForeColor = Color.FromArgb(30, 30, 30);
            cmbPuertoArduino2.HoveredItemBackColor = Color.FromArgb(210, 210, 210);
            cmbPuertoArduino2.HoveredItemTextColor = Color.Black;
            cmbPuertoArduino2.IsReadonly = false;
            cmbPuertoArduino2.ItemHeight = 30;
            cmbPuertoArduino2.Location = new Point(32, 136);
            cmbPuertoArduino2.MaxDropDownItems = 8;
            cmbPuertoArduino2.Name = "cmbPuertoArduino2";
            cmbPuertoArduino2.NotFoundBackColor = Color.Transparent;
            cmbPuertoArduino2.NotFoundFont = null;
            cmbPuertoArduino2.NotFoundTextColor = Color.Gray;
            cmbPuertoArduino2.PlaceholderColor = Color.FromArgb(140, 140, 140);
            cmbPuertoArduino2.PlaceholderDisappearsOnFocus = false;
            cmbPuertoArduino2.PlaceholderText = "Select an option";
            cmbPuertoArduino2.SearchTextColor = Color.Black;
            cmbPuertoArduino2.SearchTextFont = null;
            cmbPuertoArduino2.SelectedIndex = -1;
            cmbPuertoArduino2.SelectedItem = null;
            cmbPuertoArduino2.SelectedItemBackColor = Color.FromArgb(50, 50, 50);
            cmbPuertoArduino2.SelectedItemTextColor = Color.White;
            cmbPuertoArduino2.SelectedValue = null;
            cmbPuertoArduino2.Size = new Size(440, 80);
            cmbPuertoArduino2.TabIndex = 1;
            cmbPuertoArduino2.Text = "siticoneDropdown1";
            cmbPuertoArduino2.UnselectedItemTextColor = Color.FromArgb(30, 30, 30);
            cmbPuertoArduino2.ValueMember = null;
            // 
            // lblPuertoArduino2
            // 
            lblPuertoArduino2.Font = new Font("Segoe UI", 10F);
            lblPuertoArduino2.Location = new Point(22, 66);
            lblPuertoArduino2.Name = "lblPuertoArduino2";
            lblPuertoArduino2.Size = new Size(200, 46);
            lblPuertoArduino2.TabIndex = 0;
            lblPuertoArduino2.Text = "Puerto COM";
            // 
            // UC_Arduino
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticonePanel1);
            Name = "UC_Arduino";
            Size = new Size(1530, 1548);
            grpArduino1.ResumeLayout(false);
            siticonePanel1.ResumeLayout(false);
            grpArduino2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticoneGroupBox grpArduino1;
        private SiticoneNetCoreUI.SiticoneLabel lblPuerto1;
        private SiticoneNetCoreUI.SiticonePanel siticonePanel1;
        private SiticoneNetCoreUI.SiticoneDropdown cmbPuertoArduino1;
        private SiticoneNetCoreUI.SiticoneLabel lblEstadoArduino1;
        private SiticoneNetCoreUI.SiticoneButton btnDesconectarArduino1;
        private SiticoneNetCoreUI.SiticoneButton btnConectarArduino1;
        private SiticoneNetCoreUI.SiticoneGroupBox grpArduino2;
        private SiticoneNetCoreUI.SiticoneLabel lblEstadoArduino2;
        private SiticoneNetCoreUI.SiticoneButton btnDesconectarArduino2;
        private SiticoneNetCoreUI.SiticoneButton btnConectarArduino2;
        private SiticoneNetCoreUI.SiticoneDropdown cmbPuertoArduino2;
        private SiticoneNetCoreUI.SiticoneLabel lblPuertoArduino2;
        private RichTextBox rtbEventos;
        private SiticoneNetCoreUI.SiticoneLabel lblEventos;
        private SiticoneNetCoreUI.SiticoneButton btnActualizarPuertos;
    }
}
