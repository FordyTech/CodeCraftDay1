namespace MarsTests
{
    public class Rover
    {
        public string Direction { get; internal set; }
        public int XCoord { get; set; }
        public int YCoord { get; set; }

        public Rover(string direction, int xCoord, int yCoord)
        {
            this.Direction = direction;
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        internal void Go(string instructions)
        {
            switch (instructions)
            {
                case "R":
                    TurnRight();
                    break;
                case "L":
                    TurnLeft();
                    break;
                case "F":
                    switch (Direction)
                    {
                        case "N":
                            YCoord++;
                            break;
                    }
                    break;
            }
        }

        private void TurnLeft()
        {
            switch (Direction)
            {
                case "N":
                    Direction = "W";
                    break;
                case "W":
                    Direction = "S";
                    break;
                case "S":
                    Direction = "E";
                    break;
                default:
                    Direction = "N";
                    break;
            }
        }

        private void TurnRight()
        {
            switch (Direction)
            {
                case "N":
                    Direction = "E";
                    break;
                case "E":
                    Direction = "S";
                    break;
                case "S":
                    Direction = "W";
                    break;
                default:
                    Direction = "N";
                    break;
            }
        }
    }
}