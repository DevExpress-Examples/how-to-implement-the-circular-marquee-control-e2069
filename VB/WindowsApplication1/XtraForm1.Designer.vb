Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class XtraForm1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim scaleIndicatorState1 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState2 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState3 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState4 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState5 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState6 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState7 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState8 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState9 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState10 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState11 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState12 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState13 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState14 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState15 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState16 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState17 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState18 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState19 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState20 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
			Me.linearScaleStateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
			Me.linearScaleStateIndicatorComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent8 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent9 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent10 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
			Me.timer1 = New System.Timers.Timer()
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl2
			' 
			Me.gaugeControl2.AutoLayout = False
			Me.gaugeControl2.BackColor = System.Drawing.Color.Transparent
			Me.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gaugeControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.linearGauge1})
			Me.gaugeControl2.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl2.Name = "gaugeControl2"
			Me.gaugeControl2.Size = New System.Drawing.Size(615, 414)
			Me.gaugeControl2.TabIndex = 16
			' 
			' linearGauge1
			' 
			Me.linearGauge1.Bounds = New System.Drawing.Rectangle(5, 2, 604, 406)
			Me.linearGauge1.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() { Me.linearScaleStateIndicatorComponent1, Me.linearScaleStateIndicatorComponent2, Me.linearScaleStateIndicatorComponent3, Me.linearScaleStateIndicatorComponent4, Me.linearScaleStateIndicatorComponent5, Me.linearScaleStateIndicatorComponent6, Me.linearScaleStateIndicatorComponent7, Me.linearScaleStateIndicatorComponent8, Me.linearScaleStateIndicatorComponent9, Me.linearScaleStateIndicatorComponent10})
			Me.linearGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() { Me.labelComponent1})
			Me.linearGauge1.Name = "RatingControl2"
			Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() { Me.linearScaleComponent1})
			' 
			' linearScaleStateIndicatorComponent1
			' 
			Me.linearScaleStateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 125F)
			Me.linearScaleStateIndicatorComponent1.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent1.Name = "Indicator0"
			Me.linearScaleStateIndicatorComponent1.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState1.IntervalLength = 100F
			scaleIndicatorState1.Name = "Colored"
			scaleIndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState1.StartValue = 0.01F
			scaleIndicatorState2.IntervalLength = 0F
			scaleIndicatorState2.Name = "Empty"
			scaleIndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState1, scaleIndicatorState2})
			Me.linearScaleStateIndicatorComponent1.ZOrder = 100
			' 
			' linearScaleComponent1
			' 
			Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 225F)
			Me.linearScaleComponent1.MajorTickCount = 2
			Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -20F
			Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
			Me.linearScaleComponent1.MajorTickmark.ShowText = False
			Me.linearScaleComponent1.MajorTickmark.ShowTick = False
			Me.linearScaleComponent1.MajorTickmark.TextOffset = -32F
			Me.linearScaleComponent1.MaxValue = 100F
			Me.linearScaleComponent1.MinorTickCount = 0
			Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -14F
			Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
			Me.linearScaleComponent1.MinorTickmark.ShowTick = False
			Me.linearScaleComponent1.Name = "scale1"
			Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 25F)
			Me.linearScaleComponent1.Value = 100F
			' 
			' linearScaleStateIndicatorComponent2
			' 
			Me.linearScaleStateIndicatorComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(22.05F, 95.61F)
			Me.linearScaleStateIndicatorComponent2.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent2.Name = "Indicator1"
			Me.linearScaleStateIndicatorComponent2.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState3.IntervalLength = 90F
			scaleIndicatorState3.Name = "Colored"
			scaleIndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState3.StartValue = 10F
			scaleIndicatorState4.IntervalLength = 10F
			scaleIndicatorState4.Name = "Empty"
			scaleIndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent2.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState3, scaleIndicatorState4})
			Me.linearScaleStateIndicatorComponent2.ZOrder = 99
			' 
			' linearScaleStateIndicatorComponent3
			' 
			Me.linearScaleStateIndicatorComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(47.05F, 77.45F)
			Me.linearScaleStateIndicatorComponent3.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent3.Name = "Indicator2"
			Me.linearScaleStateIndicatorComponent3.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState5.IntervalLength = 80F
			scaleIndicatorState5.Name = "Colored"
			scaleIndicatorState5.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState5.StartValue = 20F
			scaleIndicatorState6.IntervalLength = 20F
			scaleIndicatorState6.Name = "Empty"
			scaleIndicatorState6.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent3.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState5, scaleIndicatorState6})
			Me.linearScaleStateIndicatorComponent3.ZOrder = 98
			' 
			' linearScaleStateIndicatorComponent4
			' 
			Me.linearScaleStateIndicatorComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(77.95F, 77.45F)
			Me.linearScaleStateIndicatorComponent4.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent4.Name = "Indicator3"
			Me.linearScaleStateIndicatorComponent4.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState7.IntervalLength = 70F
			scaleIndicatorState7.Name = "Colored"
			scaleIndicatorState7.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState7.StartValue = 40F
			scaleIndicatorState8.IntervalLength = 30F
			scaleIndicatorState8.Name = "Empty"
			scaleIndicatorState8.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent4.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState7, scaleIndicatorState8})
			Me.linearScaleStateIndicatorComponent4.ZOrder = 97
			' 
			' linearScaleStateIndicatorComponent5
			' 
			Me.linearScaleStateIndicatorComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(102.95F, 95.61F)
			Me.linearScaleStateIndicatorComponent5.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent5.Name = "Indicator4"
			Me.linearScaleStateIndicatorComponent5.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState9.IntervalLength = 60F
			scaleIndicatorState9.Name = "Colored"
			scaleIndicatorState9.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState9.StartValue = 40F
			scaleIndicatorState10.IntervalLength = 40F
			scaleIndicatorState10.Name = "Empty"
			scaleIndicatorState10.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent5.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState9, scaleIndicatorState10})
			Me.linearScaleStateIndicatorComponent5.ZOrder = 96
			' 
			' linearScaleStateIndicatorComponent6
			' 
			Me.linearScaleStateIndicatorComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 125F)
			Me.linearScaleStateIndicatorComponent6.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent6.Name = "Indicator5"
			Me.linearScaleStateIndicatorComponent6.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState11.IntervalLength = 50F
			scaleIndicatorState11.Name = "Colored"
			scaleIndicatorState11.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState11.StartValue = 50F
			scaleIndicatorState12.IntervalLength = 50F
			scaleIndicatorState12.Name = "Empty"
			scaleIndicatorState12.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent6.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState11, scaleIndicatorState12})
			Me.linearScaleStateIndicatorComponent6.ZOrder = 95
			' 
			' linearScaleStateIndicatorComponent7
			' 
			Me.linearScaleStateIndicatorComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(102.92F, 154.39F)
			Me.linearScaleStateIndicatorComponent7.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent7.Name = "Indicator6"
			Me.linearScaleStateIndicatorComponent7.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState13.IntervalLength = 40F
			scaleIndicatorState13.Name = "Colored"
			scaleIndicatorState13.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState13.StartValue = 60F
			scaleIndicatorState14.IntervalLength = 60F
			scaleIndicatorState14.Name = "Empty"
			scaleIndicatorState14.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent7.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState13, scaleIndicatorState14})
			Me.linearScaleStateIndicatorComponent7.ZOrder = 94
			' 
			' linearScaleStateIndicatorComponent8
			' 
			Me.linearScaleStateIndicatorComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(77.95F, 172.55F)
			Me.linearScaleStateIndicatorComponent8.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent8.Name = "Indicator7"
			Me.linearScaleStateIndicatorComponent8.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState15.IntervalLength = 30F
			scaleIndicatorState15.Name = "Colored"
			scaleIndicatorState15.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState15.StartValue = 70F
			scaleIndicatorState16.IntervalLength = 70F
			scaleIndicatorState16.Name = "Empty"
			scaleIndicatorState16.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent8.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState15, scaleIndicatorState16})
			Me.linearScaleStateIndicatorComponent8.ZOrder = 93
			' 
			' linearScaleStateIndicatorComponent9
			' 
			Me.linearScaleStateIndicatorComponent9.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(47.05F, 172.55F)
			Me.linearScaleStateIndicatorComponent9.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent9.Name = "Indicator8"
			Me.linearScaleStateIndicatorComponent9.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState17.IntervalLength = 20F
			scaleIndicatorState17.Name = "Colored"
			scaleIndicatorState17.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState17.StartValue = 80F
			scaleIndicatorState18.IntervalLength = 80F
			scaleIndicatorState18.Name = "Empty"
			scaleIndicatorState18.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent9.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState17, scaleIndicatorState18})
			Me.linearScaleStateIndicatorComponent9.ZOrder = 92
			' 
			' linearScaleStateIndicatorComponent10
			' 
			Me.linearScaleStateIndicatorComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(22.05F, 154.39F)
			Me.linearScaleStateIndicatorComponent10.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent10.Name = "Indicator9"
			Me.linearScaleStateIndicatorComponent10.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState19.IntervalLength = 10F
			scaleIndicatorState19.Name = "Colored"
			scaleIndicatorState19.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState19.StartValue = 90F
			scaleIndicatorState20.IntervalLength = 90F
			scaleIndicatorState20.Name = "Empty"
			scaleIndicatorState20.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent10.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState19, scaleIndicatorState20})
			Me.linearScaleStateIndicatorComponent10.ZOrder = 91
			' 
			' labelComponent1
			' 
			Me.labelComponent1.AppearanceText.Font = New System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelComponent1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.labelComponent1.Name = "linearGauge1_Label1"
			Me.labelComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(58.2F, 31.1F)
			Me.labelComponent1.Size = New System.Drawing.SizeF(350F, 50F)
			Me.labelComponent1.Text = "LOADING"
			Me.labelComponent1.ZOrder = -1001
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.SynchronizingObject = Me
'			Me.timer1.Elapsed += New System.Timers.ElapsedEventHandler(Me.timer1_Elapsed);
			' 
			' XtraForm1
			' 
			Me.Appearance.BackColor = System.Drawing.Color.White
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(615, 414)
			Me.Controls.Add(Me.gaugeControl2)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "XtraForm1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "XtraForm1"
			Me.TransparencyKey = System.Drawing.Color.White
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
		Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
		Private linearScaleStateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
		Private linearScaleStateIndicatorComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent8 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent9 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent10 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private labelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent
		Private WithEvents timer1 As System.Timers.Timer
	End Class
End Namespace