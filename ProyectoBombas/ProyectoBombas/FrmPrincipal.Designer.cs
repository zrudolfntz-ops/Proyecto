namespace ProyectoBombas
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlMenu = new SiticoneNetCoreUI.SiticonePanel();
            btnArduino = new SiticoneNetCoreUI.SiticoneButton();
            btnDashboard = new SiticoneNetCoreUI.SiticoneButton();
            lblSistema = new SiticoneNetCoreUI.SiticoneLabel();
            picLogo = new SiticoneNetCoreUI.SiticonePictureBox();
            pnlHeader = new SiticoneNetCoreUI.SiticonePanel();
            pnlContenido = new SiticoneNetCoreUI.SiticonePanel();
            mySiticoneLicenseSettings1 = new SiticoneNetCoreUI.MySiticoneLicenseSettings();
            btnBombas = new SiticoneNetCoreUI.SiticoneButton();
            btnAbastecimiento = new SiticoneNetCoreUI.SiticoneButton();
            btnHistorial = new SiticoneNetCoreUI.SiticoneButton();
            btnReportes = new SiticoneNetCoreUI.SiticoneButton();
            lblTituloPagina = new SiticoneNetCoreUI.SiticoneLabel();
            pnlMenu.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlMenu.BackColor = Color.Transparent;
            pnlMenu.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            pnlMenu.BorderColor = Color.Gray;
            pnlMenu.BorderDashPattern = null;
            pnlMenu.BorderGradientEndColor = Color.Purple;
            pnlMenu.BorderGradientStartColor = Color.Blue;
            pnlMenu.BorderThickness = 2F;
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnHistorial);
            pnlMenu.Controls.Add(btnAbastecimiento);
            pnlMenu.Controls.Add(btnBombas);
            pnlMenu.Controls.Add(btnArduino);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(lblSistema);
            pnlMenu.Controls.Add(picLogo);
            pnlMenu.CornerRadiusBottomLeft = 0F;
            pnlMenu.CornerRadiusBottomRight = 0F;
            pnlMenu.CornerRadiusTopLeft = 0F;
            pnlMenu.CornerRadiusTopRight = 0F;
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.EnableAcrylicEffect = false;
            pnlMenu.EnableMicaEffect = false;
            pnlMenu.EnableRippleEffect = false;
            pnlMenu.FillColor = Color.White;
            pnlMenu.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlMenu.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlMenu.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            pnlMenu.RippleAlpha = 50;
            pnlMenu.RippleAlphaDecrement = 3;
            pnlMenu.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlMenu.RippleMaxSize = 600F;
            pnlMenu.RippleSpeed = 15F;
            pnlMenu.ShowBorder = true;
            pnlMenu.Size = new Size(200, 1154);
            pnlMenu.TabIndex = 0;
            pnlMenu.TabStop = true;
            pnlMenu.UseBorderGradient = false;
            pnlMenu.UseMultiGradient = false;
            pnlMenu.UsePatternTexture = false;
            pnlMenu.UseRadialGradient = false;
            // 
            // btnArduino
            // 
            btnArduino.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnArduino.AccessibleName = "Configuración Arduino";
            btnArduino.AutoSizeBasedOnText = false;
            btnArduino.BackColor = Color.Transparent;
            btnArduino.BadgeBackColor = Color.Black;
            btnArduino.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnArduino.BadgeValue = 0;
            btnArduino.BadgeValueForeColor = Color.White;
            btnArduino.BorderColor = Color.FromArgb(60, 60, 60);
            btnArduino.BorderWidth = 2;
            btnArduino.ButtonBackColor = Color.FromArgb(30, 30, 30);
            btnArduino.ButtonImage = null;
            btnArduino.ButtonTextLeftPadding = 0;
            btnArduino.CanBeep = true;
            btnArduino.CanGlow = false;
            btnArduino.CanShake = true;
            btnArduino.ContextMenuStripEx = null;
            btnArduino.CornerRadiusBottomLeft = 6;
            btnArduino.CornerRadiusBottomRight = 6;
            btnArduino.CornerRadiusTopLeft = 6;
            btnArduino.CornerRadiusTopRight = 6;
            btnArduino.CustomCursor = Cursors.Default;
            btnArduino.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnArduino.EnableLongPress = false;
            btnArduino.EnableRippleEffect = true;
            btnArduino.EnableShadow = false;
            btnArduino.EnableTextWrapping = false;
            btnArduino.Font = new Font("Segoe UI Semibold", 10.2F);
            btnArduino.GlowColor = Color.FromArgb(30, 255, 255, 255);
            btnArduino.GlowIntensity = 100;
            btnArduino.GlowRadius = 20F;
            btnArduino.GradientBackground = false;
            btnArduino.GradientColor = Color.FromArgb(0, 227, 64);
            btnArduino.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnArduino.HintText = null;
            btnArduino.HoverBackColor = Color.FromArgb(50, 50, 50);
            btnArduino.HoverFontStyle = FontStyle.Regular;
            btnArduino.HoverTextColor = Color.White;
            btnArduino.HoverTransitionDuration = 140;
            btnArduino.ImageAlign = ContentAlignment.MiddleLeft;
            btnArduino.ImagePadding = 5;
            btnArduino.ImageSize = new Size(16, 16);
            btnArduino.IsRadial = false;
            btnArduino.IsReadOnly = false;
            btnArduino.IsToggleButton = false;
            btnArduino.IsToggled = false;
            btnArduino.Location = new Point(5, 395);
            btnArduino.LongPressDurationMS = 1000;
            btnArduino.Name = "btnArduino";
            btnArduino.NormalFontStyle = FontStyle.Regular;
            btnArduino.ParticleColor = Color.FromArgb(200, 200, 200);
            btnArduino.ParticleCount = 15;
            btnArduino.PressAnimationScale = 0.97F;
            btnArduino.PressedBackColor = Color.FromArgb(40, 40, 40);
            btnArduino.PressedFontStyle = FontStyle.Regular;
            btnArduino.PressTransitionDuration = 90;
            btnArduino.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnArduino.RippleColor = Color.FromArgb(100, 100, 100);
            btnArduino.RippleRadiusMultiplier = 0.6F;
            btnArduino.ShadowBlur = 5;
            btnArduino.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnArduino.ShadowOffset = new Point(0, 2);
            btnArduino.ShakeDuration = 500;
            btnArduino.ShakeIntensity = 5;
            btnArduino.Size = new Size(380, 100);
            btnArduino.TabIndex = 3;
            btnArduino.Text = "Configuración Arduino";
            btnArduino.TextAlign = ContentAlignment.MiddleCenter;
            btnArduino.TextColor = Color.White;
            btnArduino.TooltipText = null;
            btnArduino.UseAdvancedRendering = true;
            btnArduino.UseParticles = false;
            // 
            // btnDashboard
            // 
            btnDashboard.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnDashboard.AccessibleName = "Dashboard";
            btnDashboard.AutoSizeBasedOnText = false;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BadgeBackColor = Color.Black;
            btnDashboard.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDashboard.BadgeValue = 0;
            btnDashboard.BadgeValueForeColor = Color.White;
            btnDashboard.BorderColor = Color.FromArgb(60, 60, 60);
            btnDashboard.BorderWidth = 2;
            btnDashboard.ButtonBackColor = Color.FromArgb(30, 30, 30);
            btnDashboard.ButtonImage = null;
            btnDashboard.ButtonTextLeftPadding = 0;
            btnDashboard.CanBeep = true;
            btnDashboard.CanGlow = false;
            btnDashboard.CanShake = true;
            btnDashboard.ContextMenuStripEx = null;
            btnDashboard.CornerRadiusBottomLeft = 6;
            btnDashboard.CornerRadiusBottomRight = 6;
            btnDashboard.CornerRadiusTopLeft = 6;
            btnDashboard.CornerRadiusTopRight = 6;
            btnDashboard.CustomCursor = Cursors.Default;
            btnDashboard.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnDashboard.EnableLongPress = false;
            btnDashboard.EnableRippleEffect = true;
            btnDashboard.EnableShadow = false;
            btnDashboard.EnableTextWrapping = false;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10.2F);
            btnDashboard.GlowColor = Color.FromArgb(30, 255, 255, 255);
            btnDashboard.GlowIntensity = 100;
            btnDashboard.GlowRadius = 20F;
            btnDashboard.GradientBackground = false;
            btnDashboard.GradientColor = Color.FromArgb(0, 227, 64);
            btnDashboard.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnDashboard.HintText = null;
            btnDashboard.HoverBackColor = Color.FromArgb(50, 50, 50);
            btnDashboard.HoverFontStyle = FontStyle.Regular;
            btnDashboard.HoverTextColor = Color.White;
            btnDashboard.HoverTransitionDuration = 140;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.ImagePadding = 5;
            btnDashboard.ImageSize = new Size(16, 16);
            btnDashboard.IsRadial = false;
            btnDashboard.IsReadOnly = false;
            btnDashboard.IsToggleButton = false;
            btnDashboard.IsToggled = false;
            btnDashboard.Location = new Point(5, 289);
            btnDashboard.LongPressDurationMS = 1000;
            btnDashboard.Name = "btnDashboard";
            btnDashboard.NormalFontStyle = FontStyle.Regular;
            btnDashboard.ParticleColor = Color.FromArgb(200, 200, 200);
            btnDashboard.ParticleCount = 15;
            btnDashboard.PressAnimationScale = 0.97F;
            btnDashboard.PressedBackColor = Color.FromArgb(40, 40, 40);
            btnDashboard.PressedFontStyle = FontStyle.Regular;
            btnDashboard.PressTransitionDuration = 90;
            btnDashboard.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnDashboard.RippleColor = Color.FromArgb(100, 100, 100);
            btnDashboard.RippleRadiusMultiplier = 0.6F;
            btnDashboard.ShadowBlur = 5;
            btnDashboard.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnDashboard.ShadowOffset = new Point(0, 2);
            btnDashboard.ShakeDuration = 500;
            btnDashboard.ShakeIntensity = 5;
            btnDashboard.Size = new Size(380, 100);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleCenter;
            btnDashboard.TextColor = Color.White;
            btnDashboard.TooltipText = null;
            btnDashboard.UseAdvancedRendering = true;
            btnDashboard.UseParticles = false;
            // 
            // lblSistema
            // 
            lblSistema.Font = new Font("Segoe UI", 10F);
            lblSistema.Location = new Point(12, 240);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(200, 46);
            lblSistema.TabIndex = 1;
            lblSistema.Text = "Gasolinera";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(30, 0, 0, 0);
            picLogo.BorderColor = Color.Black;
            picLogo.BorderWidth = 1;
            picLogo.Brightness = 1F;
            picLogo.Contrast = 1F;
            picLogo.CornerRadius = 0;
            picLogo.DraggingSpeed = 3.15F;
            picLogo.EnableAsyncLoading = false;
            picLogo.EnableCaching = false;
            picLogo.EnableDragDrop = false;
            picLogo.EnableExtendedImageSources = false;
            picLogo.EnableFilters = false;
            picLogo.EnableFlipping = false;
            picLogo.EnableGlow = false;
            picLogo.EnableHighDpiSupport = false;
            picLogo.EnableMouseInteraction = false;
            picLogo.EnablePlaceholder = false;
            picLogo.EnableRotation = false;
            picLogo.EnableShadow = false;
            picLogo.EnableSlideshow = false;
            picLogo.FlipHorizontal = false;
            picLogo.FlipVertical = false;
            picLogo.Grayscale = false;
            picLogo.Image = null;
            picLogo.ImageOpacity = 1F;
            picLogo.Images = (List<Image>)resources.GetObject("picLogo.Images");
            picLogo.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            picLogo.IsCircular = false;
            picLogo.Location = new Point(12, 70);
            picLogo.MaintainAspectRatio = true;
            picLogo.Name = "picLogo";
            picLogo.PlaceholderImage = null;
            picLogo.RotationAngle = 0F;
            picLogo.Saturation = 1F;
            picLogo.ShowBorder = true;
            picLogo.Size = new Size(150, 150);
            picLogo.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            picLogo.TabIndex = 0;
            picLogo.Text = "siticonePictureBox1";
            // 
            // pnlHeader
            // 
            pnlHeader.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            pnlHeader.BorderColor = Color.Gray;
            pnlHeader.BorderDashPattern = null;
            pnlHeader.BorderGradientEndColor = Color.Silver;
            pnlHeader.BorderGradientStartColor = Color.Gainsboro;
            pnlHeader.BorderThickness = 2F;
            pnlHeader.Controls.Add(lblTituloPagina);
            pnlHeader.CornerRadiusBottomLeft = 0F;
            pnlHeader.CornerRadiusBottomRight = 0F;
            pnlHeader.CornerRadiusTopLeft = 0F;
            pnlHeader.CornerRadiusTopRight = 0F;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.EnableAcrylicEffect = false;
            pnlHeader.EnableMicaEffect = false;
            pnlHeader.EnableRippleEffect = false;
            pnlHeader.FillColor = Color.White;
            pnlHeader.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlHeader.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlHeader.Location = new Point(200, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlHeader.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            pnlHeader.RippleAlpha = 50;
            pnlHeader.RippleAlphaDecrement = 3;
            pnlHeader.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlHeader.RippleMaxSize = 600F;
            pnlHeader.RippleSpeed = 15F;
            pnlHeader.ShowBorder = true;
            pnlHeader.Size = new Size(1304, 70);
            pnlHeader.TabIndex = 1;
            pnlHeader.TabStop = true;
            pnlHeader.UseBorderGradient = false;
            pnlHeader.UseMultiGradient = false;
            pnlHeader.UsePatternTexture = false;
            pnlHeader.UseRadialGradient = false;
            // 
            // pnlContenido
            // 
            pnlContenido.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlContenido.BackColor = Color.Transparent;
            pnlContenido.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            pnlContenido.BorderColor = Color.Gray;
            pnlContenido.BorderDashPattern = null;
            pnlContenido.BorderGradientEndColor = Color.Purple;
            pnlContenido.BorderGradientStartColor = Color.Blue;
            pnlContenido.BorderThickness = 2F;
            pnlContenido.CornerRadiusBottomLeft = 0F;
            pnlContenido.CornerRadiusBottomRight = 0F;
            pnlContenido.CornerRadiusTopLeft = 0F;
            pnlContenido.CornerRadiusTopRight = 0F;
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.EnableAcrylicEffect = false;
            pnlContenido.EnableMicaEffect = false;
            pnlContenido.EnableRippleEffect = false;
            pnlContenido.FillColor = Color.White;
            pnlContenido.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlContenido.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlContenido.Location = new Point(200, 70);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlContenido.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            pnlContenido.RippleAlpha = 50;
            pnlContenido.RippleAlphaDecrement = 3;
            pnlContenido.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlContenido.RippleMaxSize = 600F;
            pnlContenido.RippleSpeed = 15F;
            pnlContenido.ShowBorder = true;
            pnlContenido.Size = new Size(1304, 1084);
            pnlContenido.TabIndex = 2;
            pnlContenido.TabStop = true;
            pnlContenido.UseBorderGradient = false;
            pnlContenido.UseMultiGradient = false;
            pnlContenido.UsePatternTexture = false;
            pnlContenido.UseRadialGradient = false;
            // 
            // btnBombas
            // 
            btnBombas.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnBombas.AccessibleName = "Bombas";
            btnBombas.AutoSizeBasedOnText = false;
            btnBombas.BackColor = Color.Transparent;
            btnBombas.BadgeBackColor = Color.Black;
            btnBombas.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnBombas.BadgeValue = 0;
            btnBombas.BadgeValueForeColor = Color.White;
            btnBombas.BorderColor = Color.FromArgb(213, 216, 220);
            btnBombas.BorderWidth = 1;
            btnBombas.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnBombas.ButtonImage = null;
            btnBombas.ButtonTextLeftPadding = 0;
            btnBombas.CanBeep = true;
            btnBombas.CanGlow = false;
            btnBombas.CanShake = true;
            btnBombas.ContextMenuStripEx = null;
            btnBombas.CornerRadiusBottomLeft = 6;
            btnBombas.CornerRadiusBottomRight = 6;
            btnBombas.CornerRadiusTopLeft = 6;
            btnBombas.CornerRadiusTopRight = 6;
            btnBombas.CustomCursor = Cursors.Default;
            btnBombas.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnBombas.EnableLongPress = false;
            btnBombas.EnableRippleEffect = true;
            btnBombas.EnableShadow = false;
            btnBombas.EnableTextWrapping = false;
            btnBombas.Font = new Font("Segoe UI Semibold", 10.2F);
            btnBombas.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnBombas.GlowIntensity = 100;
            btnBombas.GlowRadius = 20F;
            btnBombas.GradientBackground = false;
            btnBombas.GradientColor = Color.FromArgb(0, 227, 64);
            btnBombas.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnBombas.HintText = null;
            btnBombas.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnBombas.HoverFontStyle = FontStyle.Regular;
            btnBombas.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnBombas.HoverTransitionDuration = 140;
            btnBombas.ImageAlign = ContentAlignment.MiddleLeft;
            btnBombas.ImagePadding = 5;
            btnBombas.ImageSize = new Size(16, 16);
            btnBombas.IsRadial = false;
            btnBombas.IsReadOnly = false;
            btnBombas.IsToggleButton = false;
            btnBombas.IsToggled = false;
            btnBombas.Location = new Point(12, 501);
            btnBombas.LongPressDurationMS = 1000;
            btnBombas.Name = "btnBombas";
            btnBombas.NormalFontStyle = FontStyle.Regular;
            btnBombas.ParticleColor = Color.FromArgb(200, 200, 200);
            btnBombas.ParticleCount = 15;
            btnBombas.PressAnimationScale = 0.97F;
            btnBombas.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnBombas.PressedFontStyle = FontStyle.Regular;
            btnBombas.PressTransitionDuration = 90;
            btnBombas.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnBombas.RippleColor = Color.FromArgb(0, 0, 0);
            btnBombas.RippleRadiusMultiplier = 0.6F;
            btnBombas.ShadowBlur = 5;
            btnBombas.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnBombas.ShadowOffset = new Point(0, 2);
            btnBombas.ShakeDuration = 500;
            btnBombas.ShakeIntensity = 5;
            btnBombas.Size = new Size(380, 100);
            btnBombas.TabIndex = 4;
            btnBombas.Text = "Bombas";
            btnBombas.TextAlign = ContentAlignment.MiddleCenter;
            btnBombas.TextColor = Color.FromArgb(0, 0, 0);
            btnBombas.TooltipText = null;
            btnBombas.UseAdvancedRendering = true;
            btnBombas.UseParticles = false;
            // 
            // btnAbastecimiento
            // 
            btnAbastecimiento.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnAbastecimiento.AccessibleName = "Abastecimientos";
            btnAbastecimiento.AutoSizeBasedOnText = false;
            btnAbastecimiento.BackColor = Color.Transparent;
            btnAbastecimiento.BadgeBackColor = Color.Black;
            btnAbastecimiento.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAbastecimiento.BadgeValue = 0;
            btnAbastecimiento.BadgeValueForeColor = Color.White;
            btnAbastecimiento.BorderColor = Color.FromArgb(213, 216, 220);
            btnAbastecimiento.BorderWidth = 1;
            btnAbastecimiento.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnAbastecimiento.ButtonImage = null;
            btnAbastecimiento.ButtonTextLeftPadding = 0;
            btnAbastecimiento.CanBeep = true;
            btnAbastecimiento.CanGlow = false;
            btnAbastecimiento.CanShake = true;
            btnAbastecimiento.ContextMenuStripEx = null;
            btnAbastecimiento.CornerRadiusBottomLeft = 6;
            btnAbastecimiento.CornerRadiusBottomRight = 6;
            btnAbastecimiento.CornerRadiusTopLeft = 6;
            btnAbastecimiento.CornerRadiusTopRight = 6;
            btnAbastecimiento.CustomCursor = Cursors.Default;
            btnAbastecimiento.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnAbastecimiento.EnableLongPress = false;
            btnAbastecimiento.EnableRippleEffect = true;
            btnAbastecimiento.EnableShadow = false;
            btnAbastecimiento.EnableTextWrapping = false;
            btnAbastecimiento.Font = new Font("Segoe UI Semibold", 10.2F);
            btnAbastecimiento.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnAbastecimiento.GlowIntensity = 100;
            btnAbastecimiento.GlowRadius = 20F;
            btnAbastecimiento.GradientBackground = false;
            btnAbastecimiento.GradientColor = Color.FromArgb(0, 227, 64);
            btnAbastecimiento.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnAbastecimiento.HintText = null;
            btnAbastecimiento.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnAbastecimiento.HoverFontStyle = FontStyle.Regular;
            btnAbastecimiento.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnAbastecimiento.HoverTransitionDuration = 140;
            btnAbastecimiento.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbastecimiento.ImagePadding = 5;
            btnAbastecimiento.ImageSize = new Size(16, 16);
            btnAbastecimiento.IsRadial = false;
            btnAbastecimiento.IsReadOnly = false;
            btnAbastecimiento.IsToggleButton = false;
            btnAbastecimiento.IsToggled = false;
            btnAbastecimiento.Location = new Point(12, 620);
            btnAbastecimiento.LongPressDurationMS = 1000;
            btnAbastecimiento.Name = "btnAbastecimiento";
            btnAbastecimiento.NormalFontStyle = FontStyle.Regular;
            btnAbastecimiento.ParticleColor = Color.FromArgb(200, 200, 200);
            btnAbastecimiento.ParticleCount = 15;
            btnAbastecimiento.PressAnimationScale = 0.97F;
            btnAbastecimiento.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnAbastecimiento.PressedFontStyle = FontStyle.Regular;
            btnAbastecimiento.PressTransitionDuration = 90;
            btnAbastecimiento.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnAbastecimiento.RippleColor = Color.FromArgb(0, 0, 0);
            btnAbastecimiento.RippleRadiusMultiplier = 0.6F;
            btnAbastecimiento.ShadowBlur = 5;
            btnAbastecimiento.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnAbastecimiento.ShadowOffset = new Point(0, 2);
            btnAbastecimiento.ShakeDuration = 500;
            btnAbastecimiento.ShakeIntensity = 5;
            btnAbastecimiento.Size = new Size(380, 100);
            btnAbastecimiento.TabIndex = 5;
            btnAbastecimiento.Text = "Abastecimientos";
            btnAbastecimiento.TextAlign = ContentAlignment.MiddleCenter;
            btnAbastecimiento.TextColor = Color.FromArgb(0, 0, 0);
            btnAbastecimiento.TooltipText = null;
            btnAbastecimiento.UseAdvancedRendering = true;
            btnAbastecimiento.UseParticles = false;
            // 
            // btnHistorial
            // 
            btnHistorial.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnHistorial.AccessibleName = "Historial";
            btnHistorial.AutoSizeBasedOnText = false;
            btnHistorial.BackColor = Color.Transparent;
            btnHistorial.BadgeBackColor = Color.Black;
            btnHistorial.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnHistorial.BadgeValue = 0;
            btnHistorial.BadgeValueForeColor = Color.White;
            btnHistorial.BorderColor = Color.FromArgb(15, 76, 117);
            btnHistorial.BorderWidth = 2;
            btnHistorial.ButtonBackColor = Color.FromArgb(23, 107, 135);
            btnHistorial.ButtonImage = null;
            btnHistorial.ButtonTextLeftPadding = 0;
            btnHistorial.CanBeep = true;
            btnHistorial.CanGlow = true;
            btnHistorial.CanShake = true;
            btnHistorial.ContextMenuStripEx = null;
            btnHistorial.CornerRadiusBottomLeft = 4;
            btnHistorial.CornerRadiusBottomRight = 4;
            btnHistorial.CornerRadiusTopLeft = 4;
            btnHistorial.CornerRadiusTopRight = 4;
            btnHistorial.CustomCursor = Cursors.Default;
            btnHistorial.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnHistorial.EnableLongPress = false;
            btnHistorial.EnableRippleEffect = true;
            btnHistorial.EnableShadow = true;
            btnHistorial.EnableTextWrapping = false;
            btnHistorial.Font = new Font("Segoe UI Semibold", 10.2F);
            btnHistorial.GlowColor = Color.FromArgb(50, 100, 200, 255);
            btnHistorial.GlowIntensity = 100;
            btnHistorial.GlowRadius = 20F;
            btnHistorial.GradientBackground = false;
            btnHistorial.GradientColor = Color.FromArgb(0, 227, 64);
            btnHistorial.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnHistorial.HintText = null;
            btnHistorial.HoverBackColor = Color.FromArgb(27, 133, 184);
            btnHistorial.HoverFontStyle = FontStyle.Regular;
            btnHistorial.HoverTextColor = Color.White;
            btnHistorial.HoverTransitionDuration = 140;
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorial.ImagePadding = 5;
            btnHistorial.ImageSize = new Size(16, 16);
            btnHistorial.IsRadial = false;
            btnHistorial.IsReadOnly = false;
            btnHistorial.IsToggleButton = false;
            btnHistorial.IsToggled = false;
            btnHistorial.Location = new Point(12, 726);
            btnHistorial.LongPressDurationMS = 1000;
            btnHistorial.Name = "btnHistorial";
            btnHistorial.NormalFontStyle = FontStyle.Regular;
            btnHistorial.ParticleColor = Color.FromArgb(200, 200, 200);
            btnHistorial.ParticleCount = 15;
            btnHistorial.PressAnimationScale = 0.97F;
            btnHistorial.PressedBackColor = Color.FromArgb(15, 76, 117);
            btnHistorial.PressedFontStyle = FontStyle.Regular;
            btnHistorial.PressTransitionDuration = 90;
            btnHistorial.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnHistorial.RippleColor = Color.FromArgb(128, 255, 255, 255);
            btnHistorial.RippleRadiusMultiplier = 0.6F;
            btnHistorial.ShadowBlur = 5;
            btnHistorial.ShadowColor = Color.FromArgb(50, 0, 64, 128);
            btnHistorial.ShadowOffset = new Point(0, 2);
            btnHistorial.ShakeDuration = 500;
            btnHistorial.ShakeIntensity = 5;
            btnHistorial.Size = new Size(380, 100);
            btnHistorial.TabIndex = 6;
            btnHistorial.Text = "Historial";
            btnHistorial.TextAlign = ContentAlignment.MiddleCenter;
            btnHistorial.TextColor = Color.White;
            btnHistorial.TooltipText = null;
            btnHistorial.UseAdvancedRendering = true;
            btnHistorial.UseParticles = false;
            // 
            // btnReportes
            // 
            btnReportes.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnReportes.AccessibleName = "Reportes";
            btnReportes.AutoSizeBasedOnText = false;
            btnReportes.BackColor = Color.Transparent;
            btnReportes.BadgeBackColor = Color.Black;
            btnReportes.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnReportes.BadgeValue = 0;
            btnReportes.BadgeValueForeColor = Color.White;
            btnReportes.BorderColor = Color.FromArgb(213, 216, 220);
            btnReportes.BorderWidth = 1;
            btnReportes.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnReportes.ButtonImage = null;
            btnReportes.ButtonTextLeftPadding = 0;
            btnReportes.CanBeep = true;
            btnReportes.CanGlow = false;
            btnReportes.CanShake = true;
            btnReportes.ContextMenuStripEx = null;
            btnReportes.CornerRadiusBottomLeft = 6;
            btnReportes.CornerRadiusBottomRight = 6;
            btnReportes.CornerRadiusTopLeft = 6;
            btnReportes.CornerRadiusTopRight = 6;
            btnReportes.CustomCursor = Cursors.Default;
            btnReportes.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnReportes.EnableLongPress = false;
            btnReportes.EnableRippleEffect = true;
            btnReportes.EnableShadow = false;
            btnReportes.EnableTextWrapping = false;
            btnReportes.Font = new Font("Segoe UI Semibold", 10.2F);
            btnReportes.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnReportes.GlowIntensity = 100;
            btnReportes.GlowRadius = 20F;
            btnReportes.GradientBackground = false;
            btnReportes.GradientColor = Color.FromArgb(0, 227, 64);
            btnReportes.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnReportes.HintText = null;
            btnReportes.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnReportes.HoverFontStyle = FontStyle.Regular;
            btnReportes.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnReportes.HoverTransitionDuration = 140;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.ImagePadding = 5;
            btnReportes.ImageSize = new Size(16, 16);
            btnReportes.IsRadial = false;
            btnReportes.IsReadOnly = false;
            btnReportes.IsToggleButton = false;
            btnReportes.IsToggled = false;
            btnReportes.Location = new Point(5, 832);
            btnReportes.LongPressDurationMS = 1000;
            btnReportes.Name = "btnReportes";
            btnReportes.NormalFontStyle = FontStyle.Regular;
            btnReportes.ParticleColor = Color.FromArgb(200, 200, 200);
            btnReportes.ParticleCount = 15;
            btnReportes.PressAnimationScale = 0.97F;
            btnReportes.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnReportes.PressedFontStyle = FontStyle.Regular;
            btnReportes.PressTransitionDuration = 90;
            btnReportes.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnReportes.RippleColor = Color.FromArgb(0, 0, 0);
            btnReportes.RippleRadiusMultiplier = 0.6F;
            btnReportes.ShadowBlur = 5;
            btnReportes.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnReportes.ShadowOffset = new Point(0, 2);
            btnReportes.ShakeDuration = 500;
            btnReportes.ShakeIntensity = 5;
            btnReportes.Size = new Size(380, 100);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleCenter;
            btnReportes.TextColor = Color.FromArgb(0, 0, 0);
            btnReportes.TooltipText = null;
            btnReportes.UseAdvancedRendering = true;
            btnReportes.UseParticles = false;
            // 
            // lblTituloPagina
            // 
            lblTituloPagina.Font = new Font("Segoe UI", 10F);
            lblTituloPagina.ForeColor = Color.Black;
            lblTituloPagina.Location = new Point(508, 9);
            lblTituloPagina.Name = "lblTituloPagina";
            lblTituloPagina.Size = new Size(200, 46);
            lblTituloPagina.TabIndex = 0;
            lblTituloPagina.Text = "Dashboard";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 1154);
            Controls.Add(pnlContenido);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gasolinera";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticonePanel pnlMenu;
        private SiticoneNetCoreUI.SiticonePanel pnlHeader;
        private SiticoneNetCoreUI.SiticonePanel pnlContenido;
        private SiticoneNetCoreUI.SiticonePictureBox picLogo;
        private SiticoneNetCoreUI.SiticoneLabel lblSistema;
        private SiticoneNetCoreUI.SiticoneButton btnArduino;
        private SiticoneNetCoreUI.SiticoneButton btnDashboard;
        private SiticoneNetCoreUI.MySiticoneLicenseSettings mySiticoneLicenseSettings1;
        private SiticoneNetCoreUI.SiticoneButton btnHistorial;
        private SiticoneNetCoreUI.SiticoneButton btnAbastecimiento;
        private SiticoneNetCoreUI.SiticoneButton btnBombas;
        private SiticoneNetCoreUI.SiticoneButton btnReportes;
        private SiticoneNetCoreUI.SiticoneLabel lblTituloPagina;
    }
}
