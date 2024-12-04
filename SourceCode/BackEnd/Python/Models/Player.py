class Player:
    def __init__(self, uid:str) -> None:
        self.uid = uid
        self.hand = []
        self.face_down_life = []
        self.face_up_life = []