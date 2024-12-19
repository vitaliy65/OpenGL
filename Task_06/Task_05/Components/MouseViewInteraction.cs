using System;
using System.Windows.Forms;

namespace Task_05.Components
{
    public class MouseViewInteraction
    {
        private int _lastMouseX;
        private int _lastMouseY;
        private double _rotationX;
        private double _rotationY;
        private double _scale = 1;
        private double _scaleFactor = 0.05d;

        public double RotationX => _rotationX;
        public double RotationY => _rotationY;
        public double Scale => _scale;

        public void HandleMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the mouse movement deltas
                int deltaX = e.X - _lastMouseX;
                int deltaY = e.Y - _lastMouseY;

                // Update rotation angles based on mouse movement
                _rotationX += deltaY * 0.5;  // Sensitivity factor for X-axis
                _rotationY += deltaX * 0.5;  // Sensitivity factor for Y-axis
            }

            // Update last mouse position
            _lastMouseX = e.X;
            _lastMouseY = e.Y;
        }

        public void HandleMouseScale(MouseEventArgs e)
        {
            _scale += e.Delta > 0 ? _scaleFactor : -_scaleFactor;
        }

        public void UpdateLastMousePosition(int x, int y)
        {
            _lastMouseX = x;
            _lastMouseY = y;
        }
    }
}
