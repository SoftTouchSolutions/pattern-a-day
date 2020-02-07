
import 'package:tictactoe/design_patterns/abstract_factory/BoardSpace/ITicTacToeBoardSpace.dart';
import 'package:tictactoe/design_patterns/abstract_factory/BoardSpace/FlutterTicTacToeBoardSpace.dart';


class FlutterTicTacToeBoardSpace implements ITicTacToeBoardSpace{
  @overide
  ITicTacToeBoardSpace getBoardSpace(){
    return new FlutterTicTacToeBoardSpace();
  }
}