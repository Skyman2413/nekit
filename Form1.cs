using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melanchall.DryWetMidi.Devices;
using NAudio.Midi;

namespace Nekit
{
    public partial class Form1 : Form
    {
        private string _inputPath;
        private MidiOut _midiOut;
        private bool _isRecord;
        private MidiEventCollection _coll;
        private int i;
        private long startTime;
        public Form1()
        {
            InitializeComponent();
            _midiOut = new MidiOut(0);
            _isRecord = false;
            _coll = new MidiEventCollection(0, 50);
        }

        private void c_Click(object sender, EventArgs e)
        {
            
            _midiOut.Send(MidiMessage.StartNote(60,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(60,127,1).RawData);
            if (_isRecord)
            {
                
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 60, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 60, 0), 1);
                i++;            }
        }

        private void c_up_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(61,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(61,127,1).RawData);
            if (_isRecord)
            {
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 61, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 61, 0), 1);
                i++;            }
        }

        private void d_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(62,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(62,127,1).RawData);
            if (_isRecord)
            {
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 62, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 62, 0), 1);
                i++;            }
        }

        private void d_up_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(63,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(63,127,1).RawData);
            if (_isRecord)
            {
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 63, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 63, 0), 1);
                i++;            }
        }

        private void e_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(64,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(64,127,1).RawData);
            if (_isRecord)
            {
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 64, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 64, 0), 1);
                i++;            }
        }

        private void f_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(65,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(65,127,1).RawData);
            if (_isRecord)
            { 
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 65, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 65, 0), 1);
                i++;
            }
        }

        private void f_up_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(66,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(66,127,1).RawData);
            if (_isRecord)
            {
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 66, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 66, 0), 1);
                i++;            }
        }

        private void g_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(67,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(67,127,1).RawData);
            if (_isRecord)
            {
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 67, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 67, 0), 1);
                i++;            }
        }

        private void g_up_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(68,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(68,127,1).RawData);
            if (_isRecord)
            {
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 68, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 68, 0), 1);
                i++;            }
        }

        private void a_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(69,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(69,127,1).RawData);
            if (_isRecord)
            {
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 69, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 69, 0), 1);
                i++;            }
        }

        private void a_up_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(70,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(70,127,1).RawData);
            if (_isRecord)
            {
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 70, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 70, 0), 1);
                i++;            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            _midiOut.Send(MidiMessage.StartNote(71,127,1).RawData);
            Thread.Sleep(100);
            _midiOut.Send(MidiMessage.StopNote(71,127,1).RawData);
            if (_isRecord)
            {
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000,1,
                    MidiCommandCode.NoteOn, 71, 127),1 );
                _coll.AddEvent(new NoteEvent((DateTime.Now.Ticks - startTime)/90000, 1,
                    MidiCommandCode.NoteOff, 71, 0), 1);
                i++;            }
        }

        private void rec_Click(object sender, EventArgs e)
        {
            rec.Text = "Stop record";
            if (_isRecord)
            {
                MidiFile.Export(@"../../MidiFile" + DateTime.Now.Ticks + ".mid", _coll);
                _coll = new MidiEventCollection(0, 100);
                rec.Text = "Record";
            }
            _isRecord = !_isRecord;
            startTime = DateTime.Now.Ticks;

        }

        private void open_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            
            if(openFileDialog.ShowDialog() == DialogResult.OK){// Тут откроется форма и если будет нажата кнопка ОК тогда путь запишется в переменную path.
               _inputPath = openFileDialog.FileName;
            }

            _midiOut.Dispose();
            _midiOut.Close();
             try
            {
                var midiFile = Melanchall.DryWetMidi.Core.MidiFile.Read(_inputPath);
                using (var outputDevice = OutputDevice.GetByName("Microsoft GS Wavetable Synth"))
                {
                    midiFile.Play(outputDevice);
                }

            }
           catch (Exception ee)
            {
                MessageBox.Show("Unreadeble file", "error", MessageBoxButtons.OK);
            }
            
            _midiOut = new MidiOut(0);

        }
    }
}