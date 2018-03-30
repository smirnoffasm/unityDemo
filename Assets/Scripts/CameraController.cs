using UnityEngine;

namespace Assets
{
    public class CameraController : MonoBehaviour
    {
        public enum cameraMode {thirdPerson, sideProjection}
        public struct cameraPosition
        {
            public float X;
            public float Y;
            public float Z;
        }

        public int IndentZ = 3;
        public int IndentX = 3;
        public int IndentSpeed = 3;

        private float _curZ;
        private float _curX;

        private const string XAxis = "x";
        private const string ZAxis = "z";

        public cameraMode mode = cameraMode.thirdPerson;
       // public cameraPosition thirdPersonPosition = new cameraPosition( 0, 0, 0 );

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (this.mode == cameraMode.thirdPerson)
            {
                IndentByAxis(ZAxis, "w", "s", _curZ, IndentZ);
                IndentByAxis(XAxis, "a", "d", _curX, IndentX);
            }
        }

        private void IndentByAxis(string axis, string plusKey, string minusKey, float current, float max)
        {
            if (Input.GetKey(plusKey))
            {
                if (current < max)
                {
                    Indent(axis, 1);
                }
            }
            else if (Input.GetKey(minusKey))
            {
                if (current > -max)
                {
                    Indent(axis, -1);
                }
            }
            else
            {
                var indent = IndentSpeed * Time.deltaTime;
                if (indent < Mathf.Abs(current))
                {
                    if (current < 0)
                    {
                        Indent(axis, 1);
                    }
                    else
                    {
                        Indent(axis, -1);
                    }
                }
            }
        }

        private void Indent(string axis, float direction)
        {
            var indention = IndentSpeed * Time.deltaTime * direction;
            if (axis == XAxis)
            {
                _curX += indention;
                transform.Translate(indention, 0, 0);
            } else if (axis == ZAxis)
            {
                _curZ += indention;
                transform.Translate(0, 0, indention);
            }
        }

        public void switchCameraMode()
        {
            if (mode == cameraMode.thirdPerson)
            {
                mode = cameraMode.sideProjection;
            } else if (mode == cameraMode.sideProjection)
            {
                mode = cameraMode.thirdPerson;
            }
        }
    }
}